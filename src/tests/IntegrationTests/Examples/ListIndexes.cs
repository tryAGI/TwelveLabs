/*
order: 10
title: List Indexes
slug: list-indexes

Shows how to list video indexes.
*/

namespace TwelveLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListIndexes()
    {
        var apiKey = GetApiKey();
        using var client = GetAuthenticatedClient();

        //// List all video indexes in your account.
        var response = await client.SubpackageIndexes.ListAsync(
            xApiKey: apiKey);

        //// The response contains a paginated list of indexes.
        response.Data.Should().NotBeNull();
        foreach (var index in response.Data!)
        {
            Console.WriteLine($"Index: {index.IndexName} (ID: {index.Id}, Videos: {index.VideoCount})");
        }
    }
}
