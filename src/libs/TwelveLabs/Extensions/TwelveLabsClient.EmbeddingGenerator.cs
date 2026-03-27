using Microsoft.Extensions.AI;

namespace TwelveLabs;

public partial class TwelveLabsClient : IEmbeddingGenerator<string, Embedding<float>>
{
    private EmbeddingGeneratorMetadata? _embeddingMetadata;
    private string? _apiKey;

    /// <summary>
    /// Sets the API key used for the xApiKey parameter in embedding requests.
    /// Call this after construction to enable MEAI embedding generation.
    /// </summary>
    /// <param name="apiKey">The Twelve Labs API key.</param>
    /// <returns>This client for chaining.</returns>
    public TwelveLabsClient WithApiKey(string apiKey)
    {
        _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        return this;
    }

    object? IEmbeddingGenerator.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(EmbeddingGeneratorMetadata) ? (_embeddingMetadata ??= new(nameof(TwelveLabsClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<GeneratedEmbeddings<Embedding<float>>> IEmbeddingGenerator<string, Embedding<float>>.GenerateAsync(
        IEnumerable<string> values,
        EmbeddingGenerationOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(values);

        var apiKey = _apiKey ?? throw new InvalidOperationException(
            "API key not set. Call WithApiKey() before using MEAI embedding generation.");

        var texts = values as IList<string> ?? values.ToList();
        var modelId = options?.ModelId ?? "marengo3.0";

        // Twelve Labs embed v2 accepts one text per request — parallelize for throughput
        var tasks = texts.Select(async text =>
        {
            var request = new CreateEmbeddingsRequest
            {
                InputType = CreateEmbeddingsRequestInputType.Text,
                ModelName = CreateEmbeddingsRequestModelName.Marengo30,
                Text = new TextInputRequest { InputText = text },
            };

            var response = await SubpackageEmbedSubpackageEmbedV2.CreateAsync(
                xApiKey: apiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            return response.Data.Select(item =>
            {
                var floatArray = new float[item.Embedding.Count];
                for (var i = 0; i < item.Embedding.Count; i++)
                {
                    floatArray[i] = (float)item.Embedding[i];
                }

                return new Embedding<float>(floatArray) { ModelId = modelId };
            });
        }).ToList();

        var results = await Task.WhenAll(tasks).ConfigureAwait(false);
        var embeddings = new GeneratedEmbeddings<Embedding<float>>();
        foreach (var batch in results)
        {
            foreach (var embedding in batch)
            {
                embeddings.Add(embedding);
            }
        }

        return embeddings;
    }
}
