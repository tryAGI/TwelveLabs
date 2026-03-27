/*
order: 30
title: Analyze Video
slug: analyze-video

Shows how to generate text from video content using open-ended analysis.
*/

namespace TwelveLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task AnalyzeVideo()
    {
        var apiKey = GetApiKey();
        using var client = GetAuthenticatedClient();

        //// Retrieve an indexed video to analyze.
        var indexes = await client.SubpackageIndexes.ListAsync(
            xApiKey: apiKey);
        var indexId = indexes.Data?.FirstOrDefault()?.Id
            ?? throw new AssertInconclusiveException("No indexes found. Create an index and upload videos first.");

        var assets = await client.SubpackageIndexesSubpackageIndexesIndexedAssets.ListAsync(
            indexId: indexId,
            xApiKey: apiKey);
        var videoId = assets.Data?.FirstOrDefault()?.Id
            ?? throw new AssertInconclusiveException("No indexed assets found in the index.");

        //// Generate a summary of the video using open-ended analysis with streaming disabled.
        var response = await client.AnalyzeAsync(
            xApiKey: apiKey,
            videoId: videoId,
            prompt: "Provide a brief summary of this video, including the main topic and key points.",
            stream: false);

        //// The non-streaming response contains the generated text and token usage.
        var result = response.NonStreamAnalyzeResponse;
        result.Should().NotBeNull();
        Console.WriteLine($"Generated text: {result!.Data}");
        Console.WriteLine($"Finish reason: {result.FinishReason}");
    }
}
