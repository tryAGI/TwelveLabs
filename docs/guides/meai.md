# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Twelve Labs SDK implements `IEmbeddingGenerator<string, Embedding<float>>` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), providing text embeddings via the Marengo 3.0 model.

## Installation

```bash
dotnet add package TwelveLabs
```

## Text Embeddings

`TwelveLabsClient` implements `IEmbeddingGenerator<string, Embedding<float>>` for generating text embeddings using the embed v2 sync API.

```csharp
using TwelveLabs;
using Microsoft.Extensions.AI;

var apiKey = Environment.GetEnvironmentVariable("TWELVELABS_API_KEY")!;
var client = new TwelveLabsClient(apiKey);
client.WithApiKey(apiKey); // Required for MEAI embedding generation

IEmbeddingGenerator<string, Embedding<float>> generator = client;

var embeddings = await generator.GenerateAsync(["Hello, world!"]);

Console.WriteLine($"Embedding dimensions: {embeddings[0].Vector.Length}");
```

## API Key Setup

The `WithApiKey()` call is required because Twelve Labs' generated API methods require the API key as an explicit `xApiKey` parameter (in addition to the Bearer auth header). Call it once after construction:

```csharp
var client = new TwelveLabsClient(apiKey);
client.WithApiKey(apiKey);
```

## Provider Metadata

```csharp
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var metadata = generator.GetService<EmbeddingGeneratorMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "TwelveLabsClient"
Console.WriteLine($"Endpoint: {metadata?.ProviderUri}");
```

## Limitations

- **One text per request**: The Twelve Labs embed v2 API accepts a single text input per request. When passing multiple texts, the SDK calls the API once per text sequentially.
- **500 token limit**: Each text input is limited to 500 tokens.
- **Model**: Only Marengo 3.0 (`marengo3.0`) is supported.
- **Multimodal**: The SDK's MEAI interface only supports text embeddings. For image, audio, and video embeddings, use the SDK's native methods directly.

## Dependency Injection

```csharp
var builder = WebApplication.CreateBuilder(args);

var apiKey = builder.Configuration["TwelveLabs:ApiKey"]!;
builder.Services.AddSingleton<IEmbeddingGenerator<string, Embedding<float>>>(
    new TwelveLabsClient(apiKey).WithApiKey(apiKey));
```
