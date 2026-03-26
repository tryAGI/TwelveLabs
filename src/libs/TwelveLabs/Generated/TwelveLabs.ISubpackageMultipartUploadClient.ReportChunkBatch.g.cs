#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageMultipartUploadClient
    {
        /// <summary>
        /// Report uploaded chunks<br/>
        /// This method reports successfully uploaded chunks to the platform. The platform finalizes the upload after you report all chunks.<br/>
        /// For optimal performance, report chunks in batches and in any order.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.ReportChunkBatchResponse> ReportChunkBatchAsync(
            string uploadId,
            string xApiKey,

            global::TwelveLabs.ReportChunkBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Report uploaded chunks<br/>
        /// This method reports successfully uploaded chunks to the platform. The platform finalizes the upload after you report all chunks.<br/>
        /// For optimal performance, report chunks in batches and in any order.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="completedChunks">
        /// The list of chunks successfully uploaded that you're reporting to the platform. Report only after receiving an ETag.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.ReportChunkBatchResponse> ReportChunkBatchAsync(
            string uploadId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::TwelveLabs.CompletedChunk> completedChunks,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}