#nullable enable

namespace TwelveLabs
{
    public partial interface IEntityCollectionsClient
    {
        /// <summary>
        /// Delete an entity collection<br/>
        /// This method deletes the specified entity collection. This action cannot be undone.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string entityCollectionId,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an entity collection<br/>
        /// This method deletes the specified entity collection. This action cannot be undone.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse> DeleteAsResponseAsync(
            string entityCollectionId,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}