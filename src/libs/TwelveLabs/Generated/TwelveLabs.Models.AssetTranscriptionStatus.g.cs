
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Indicates the current status of the transcription.<br/>
    /// **Values**:<br/>
    /// - `pending`: The platform has not started transcribing the asset.<br/>
    /// - `processing`: The platform is transcribing the asset.<br/>
    /// - `ready`: The transcription is available.<br/>
    /// - `failed`: The platform could not transcribe the asset. The `error` field describes the reason.
    /// </summary>
    public enum AssetTranscriptionStatus
    {
        /// <summary>
        /// The platform could not transcribe the asset. The `error` field describes the reason.
        /// </summary>
        Failed,
        /// <summary>
        /// The platform has not started transcribing the asset.
        /// </summary>
        Pending,
        /// <summary>
        /// The platform is transcribing the asset.
        /// </summary>
        Processing,
        /// <summary>
        /// The transcription is available.
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetTranscriptionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetTranscriptionStatus value)
        {
            return value switch
            {
                AssetTranscriptionStatus.Failed => "failed",
                AssetTranscriptionStatus.Pending => "pending",
                AssetTranscriptionStatus.Processing => "processing",
                AssetTranscriptionStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetTranscriptionStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AssetTranscriptionStatus.Failed,
                "pending" => AssetTranscriptionStatus.Pending,
                "processing" => AssetTranscriptionStatus.Processing,
                "ready" => AssetTranscriptionStatus.Ready,
                _ => null,
            };
        }
    }
}