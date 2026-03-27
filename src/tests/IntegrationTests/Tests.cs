namespace TwelveLabs.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static string GetApiKey()
    {
        return Environment.GetEnvironmentVariable("TWELVELABS_API_KEY") is { Length: > 0 } apiKeyValue
            ? apiKeyValue
            : throw new AssertInconclusiveException("TWELVELABS_API_KEY environment variable is not found.");
    }

    private static TwelveLabsClient GetAuthenticatedClient()
    {
        var apiKey = GetApiKey();
        var client = new TwelveLabsClient(apiKey);
        
        return client;
    }
}
