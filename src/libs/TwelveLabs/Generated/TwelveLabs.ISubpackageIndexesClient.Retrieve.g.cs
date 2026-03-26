#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageIndexesClient
    {
        /// <summary>
        /// Retrieve an index<br/>
        /// This method retrieves details about the specified index.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.Index> RetrieveAsync(
            string indexId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}