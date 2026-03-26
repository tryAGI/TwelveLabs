#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient
    {
        /// <summary>
        /// List entities in an entity collection<br/>
        /// This method returns a list of the entities in the specified entity collection.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOption">
        /// Default Value: desc
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EntityCollectionsEntitiesListResponse200> ListAsync(
            string entityCollectionId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            string? name = default,
            global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus? status = default,
            global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy? sortBy = default,
            string? sortOption = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}