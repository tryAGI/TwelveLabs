# CLAUDE.md — TwelveLabs SDK

## Overview

Auto-generated C# SDK for [Twelve Labs](https://twelvelabs.io/) — video understanding platform with search, embed, generate, and indexing capabilities.
OpenAPI spec from `https://docs.twelvelabs.io/openapi.json`.

## Build & Test

```bash
dotnet build TwelveLabs.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new TwelveLabsClient(apiKey); // TWELVELABS_API_KEY env var
```

**Note:** Generated methods also require an `xApiKey` parameter (the `x-api-key` header). Pass the same API key value.

## Key Files

- `src/libs/TwelveLabs/openapi.json` — OpenAPI spec (downloaded from docs.twelvelabs.io)
- `src/libs/TwelveLabs/generate.sh` — Downloads spec, fixes auth scheme, runs autosdk
- `src/libs/TwelveLabs/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)
