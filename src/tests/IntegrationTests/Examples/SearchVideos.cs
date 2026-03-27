/*
order: 20
title: Search Videos
slug: search-videos

Shows how to search across indexed videos using a text query.
*/

namespace TwelveLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SearchVideos()
    {
        var apiKey = GetApiKey();
        using var client = GetAuthenticatedClient();

        //// Retrieve the first index to use for searching.
        var indexes = await client.SubpackageIndexes.ListAsync(
            xApiKey: apiKey);
        var indexId = indexes.Data?.FirstOrDefault()?.Id
            ?? throw new AssertInconclusiveException("No indexes found. Create an index and upload videos first.");

        //// Search for video segments matching a text query using visual search.
        var results = await client.SubpackageSearch.CreateAsync(
            xApiKey: apiKey,
            indexId: indexId,
            queryText: "a person walking",
            searchOptions: [SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems.Visual]);

        //// The response contains matching video clips with timestamps and relevance ranking.
        results.Data.Should().NotBeNull();
        foreach (var item in results.Data!)
        {
            Console.WriteLine($"Video: {item.VideoId}, Start: {item.Start}s, End: {item.End}s, Rank: {item.Rank}");
        }
    }
}
