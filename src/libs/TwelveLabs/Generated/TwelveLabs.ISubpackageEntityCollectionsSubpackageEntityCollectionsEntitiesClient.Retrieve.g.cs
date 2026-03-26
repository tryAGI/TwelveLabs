#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient
    {
        /// <summary>
        /// Retrieve an entity<br/>
        /// This method retrieves details about the specified entity.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="entityId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.Entity> RetrieveAsync(
            string entityCollectionId,
            string entityId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}