
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The status of your upload session. This field can take one of the following values:<br/>
    /// - `active`: The upload session is currently in progress. Continue uploading and reporting the completion of each chunk.<br/>
    /// - `completed`: The platform received the file. The asset is created in the `processing` status and is not yet ready to use. Poll the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) endpoint until the status of the asset is `ready` before you use it.<br/>
    /// - `failed`: The upload session failed. You must restart with a new session.<br/>
    /// - `expired`: The upload session expired after 24 hours. You must create a new session.
    /// </summary>
    public enum MultipartUploadStatusType
    {
        /// <summary>
        /// The upload session is currently in progress. Continue uploading and reporting the completion of each chunk.
        /// </summary>
        Active,
        /// <summary>
        /// The platform received the file. The asset is created in the `processing` status and is not yet ready to use. Poll the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) endpoint until the status of the asset is `ready` before you use it.
        /// </summary>
        Completed,
        /// <summary>
        /// The upload session expired after 24 hours. You must create a new session.
        /// </summary>
        Expired,
        /// <summary>
        /// The upload session failed. You must restart with a new session.
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultipartUploadStatusTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultipartUploadStatusType value)
        {
            return value switch
            {
                MultipartUploadStatusType.Active => "active",
                MultipartUploadStatusType.Completed => "completed",
                MultipartUploadStatusType.Expired => "expired",
                MultipartUploadStatusType.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultipartUploadStatusType? ToEnum(string value)
        {
            return value switch
            {
                "active" => MultipartUploadStatusType.Active,
                "completed" => MultipartUploadStatusType.Completed,
                "expired" => MultipartUploadStatusType.Expired,
                "failed" => MultipartUploadStatusType.Failed,
                _ => null,
            };
        }
    }
}