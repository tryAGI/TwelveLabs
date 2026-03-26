#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageIndexesClient
    {
        /// <summary>
        /// Update an index<br/>
        /// This method updates the name of the specified index.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAsync(
            string indexId,
            string xApiKey,

            global::TwelveLabs.UpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an index<br/>
        /// This method updates the name of the specified index.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="indexName">
        /// The name of the index.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAsync(
            string indexId,
            string xApiKey,
            string indexName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}