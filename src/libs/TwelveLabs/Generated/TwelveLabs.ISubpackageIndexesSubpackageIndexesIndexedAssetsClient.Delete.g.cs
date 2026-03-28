#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageIndexesSubpackageIndexesIndexedAssetsClient
    {
        /// <summary>
        /// Delete indexed asset information<br/>
        /// This method deletes all the information about the specified indexed asset. This action cannot be undone.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="indexedAssetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.IndexesIndexedAssetsDeleteResponse204> DeleteAsync(
            string indexId,
            string indexedAssetId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}