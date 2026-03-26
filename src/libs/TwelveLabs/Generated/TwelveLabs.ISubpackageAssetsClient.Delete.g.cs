#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAssetsClient
    {
        /// <summary>
        /// Delete an asset<br/>
        /// This method deletes the specified asset. This action cannot be undone.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string assetId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}