# Authentication

The TwelveLabs SDK uses Bearer token authentication. You can obtain an API key from your [Twelve Labs dashboard](https://dashboard.twelvelabs.io/).

## Basic Usage

```csharp
using TwelveLabs;

var client = new TwelveLabsClient(apiKey: Environment.GetEnvironmentVariable("TWELVELABS_API_KEY")!);
```

!!! note
    Some generated methods also require an `xApiKey` parameter (the `x-api-key` header). Pass the same API key value for this parameter.

## Environment Variable

| Variable | Description |
|----------|-------------|
| `TWELVELABS_API_KEY` | Your Twelve Labs API key |
