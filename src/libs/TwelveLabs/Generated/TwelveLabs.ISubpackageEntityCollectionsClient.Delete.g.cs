#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageEntityCollectionsClient
    {
        /// <summary>
        /// Delete an entity collection<br/>
        /// This method deletes the specified entity collection. This action cannot be undone.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string entityCollectionId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}