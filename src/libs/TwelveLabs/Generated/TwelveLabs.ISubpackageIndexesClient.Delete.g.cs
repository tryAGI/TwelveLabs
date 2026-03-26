#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageIndexesClient
    {
        /// <summary>
        /// Delete an index<br/>
        /// This method deletes the specified index and all the videos within it. This action cannot be undone.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string indexId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}