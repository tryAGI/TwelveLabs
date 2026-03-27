/*
order: 40
title: Text Embedding
slug: text-embedding

Shows how to generate text embeddings using the MEAI IEmbeddingGenerator interface.
*/

using Microsoft.Extensions.AI;

namespace TwelveLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextEmbedding()
    {
        var apiKey = GetApiKey();
        using var client = GetAuthenticatedClient();
        client.WithApiKey(apiKey);

        //// Use the MEAI IEmbeddingGenerator interface for text embeddings.
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var metadata = generator.GetService<EmbeddingGeneratorMetadata>();
        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("TwelveLabsClient");
    }
}
