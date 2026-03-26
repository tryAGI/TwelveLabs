#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageTasksSubpackageTasksTransfersClient
    {
        /// <summary>
        /// Get Status
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task GetStatusAsync(
            string integrationId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}