#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAnalyzeAsyncSubpackageAnalyzeAsyncTasksClient
    {
        /// <summary>
        /// Delete an analysis task<br/>
        /// This method deletes an analysis task. You can only delete tasks that are not currently being processed.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeAsyncTasksDeleteResponse204> DeleteAsync(
            string taskId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}