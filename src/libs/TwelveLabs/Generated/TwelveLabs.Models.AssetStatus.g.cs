
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Indicates the current processing status of the asset.<br/>
    /// A newly uploaded asset starts in the `processing` status and transitions asynchronously to `ready` on success or to `failed` on error, typically within a few seconds to a few minutes. Poll the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) endpoint until the status is `ready` before you use the asset in downstream workflows.<br/>
    /// **Values**:<br/>
    /// - `processing`: The asset is not yet usable. This can mean the upload is still in progress (for example, the platform is still fetching the file from a URL, or a multipart upload has not completed), or the upload has finished and the platform is validating the file. The `technical_metadata` field is omitted from the response.<br/>
    /// - `ready`: The platform validated the asset successfully, and the asset is ready to use.<br/>
    /// - `failed`: The platform could not process the file. The `error` field describes the reason, and the `technical_metadata` field may be partially populated.
    /// </summary>
    public enum AssetStatus
    {
        /// <summary>
        /// The platform could not process the file. The `error` field describes the reason, and the `technical_metadata` field may be partially populated.
        /// </summary>
        Failed,
        /// <summary>
        /// The asset is not yet usable. This can mean the upload is still in progress (for example, the platform is still fetching the file from a URL, or a multipart upload has not completed), or the upload has finished and the platform is validating the file. The `technical_metadata` field is omitted from the response.
        /// </summary>
        Processing,
        /// <summary>
        /// The platform validated the asset successfully, and the asset is ready to use.
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetStatus value)
        {
            return value switch
            {
                AssetStatus.Failed => "failed",
                AssetStatus.Processing => "processing",
                AssetStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AssetStatus.Failed,
                "processing" => AssetStatus.Processing,
                "ready" => AssetStatus.Ready,
                _ => null,
            };
        }
    }
}