#!/bin/bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.json https://docs.twelvelabs.io/openapi.json

yq -i '
  del(.components.securitySchemes) |
  .components.securitySchemes.BearerAuth = {"type": "http", "scheme": "bearer"} |
  del(.security) |
  .security = [{"BearerAuth": []}]
' openapi.json

autosdk generate openapi.json \
  --namespace TwelveLabs \
  --clientClassName TwelveLabsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
