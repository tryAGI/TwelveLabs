#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageEntityCollectionsClient
    {
        /// <summary>
        /// Retrieve an entity collection<br/>
        /// This method retrieves details about the specified entity collection.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EntityCollection> RetrieveAsync(
            string entityCollectionId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}