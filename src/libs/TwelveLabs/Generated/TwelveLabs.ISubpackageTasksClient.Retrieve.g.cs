#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageTasksClient
    {
        /// <summary>
        /// Retrieve a video indexing task<br/>
        /// This method retrieves a video indexing task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.TasksRetrieveResponse200> RetrieveAsync(
            string taskId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}