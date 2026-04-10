#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageEntityCollectionsClient
    {
        /// <summary>
        /// Update an entity collection<br/>
        /// This method updates the specified entity collection.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EntityCollection> UpdateAsync(
            string entityCollectionId,
            string xApiKey,

            global::TwelveLabs.UpdateRequest4 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an entity collection<br/>
        /// This method updates the specified entity collection.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="name">
        /// The updated name of the entity collection.
        /// </param>
        /// <param name="description">
        /// The updated description of the entity collection.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EntityCollection> UpdateAsync(
            string entityCollectionId,
            string xApiKey,
            string? name = default,
            string? description = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}