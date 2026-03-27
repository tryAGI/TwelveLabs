# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The TwelveLabs SDK implements `IEmbeddingGenerator<string, Embedding<float>>` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), enabling text embeddings via the Twelve Labs Embed v2 API.

## Installation

```bash
dotnet add package tryAGI.TwelveLabs
```

## Embedding Generation

Use the `TwelveLabsClient` as an `IEmbeddingGenerator` to generate text embeddings with the Marengo 3.0 model.

```csharp
using TwelveLabs;
using Microsoft.Extensions.AI;

var client = new TwelveLabsClient(
    apiKey: Environment.GetEnvironmentVariable("TWELVELABS_API_KEY")!)
    .WithApiKey(Environment.GetEnvironmentVariable("TWELVELABS_API_KEY")!);

IEmbeddingGenerator<string, Embedding<float>> generator = client;

var embeddings = await generator.GenerateAsync(["What is machine learning?"]);

Console.WriteLine($"Dimensions: {embeddings[0].Vector.Length}");
```

## Service Metadata

```csharp
using TwelveLabs;
using Microsoft.Extensions.AI;

var client = new TwelveLabsClient(
    apiKey: Environment.GetEnvironmentVariable("TWELVELABS_API_KEY")!)
    .WithApiKey(Environment.GetEnvironmentVariable("TWELVELABS_API_KEY")!);

IEmbeddingGenerator<string, Embedding<float>> generator = client;

var metadata = generator.GetService<EmbeddingGeneratorMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}");
```

## Notes

- The `WithApiKey()` call is required before using embedding generation (it sets the `x-api-key` header parameter)
- The default model is `marengo3.0`
- Twelve Labs Embed v2 accepts one text per request; multiple texts are parallelized automatically
- Embedding vectors are returned as `float[]`
