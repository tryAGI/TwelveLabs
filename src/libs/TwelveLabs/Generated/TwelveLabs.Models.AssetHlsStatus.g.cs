
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The status of the HLS stream.<br/>
    /// **Values**:<br/>
    /// - `pending`: The platform has not yet started HLS generation<br/>
    /// - `processing`: The platform is generating HLS segments<br/>
    /// - `ready`: The HLS stream is ready for playback<br/>
    /// - `error`: HLS generation failed
    /// </summary>
    public enum AssetHlsStatus
    {
        /// <summary>
        /// HLS generation failed
        /// </summary>
        Error,
        /// <summary>
        /// The platform has not yet started HLS generation
        /// </summary>
        Pending,
        /// <summary>
        /// The platform is generating HLS segments
        /// </summary>
        Processing,
        /// <summary>
        /// The HLS stream is ready for playback
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetHlsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetHlsStatus value)
        {
            return value switch
            {
                AssetHlsStatus.Error => "error",
                AssetHlsStatus.Pending => "pending",
                AssetHlsStatus.Processing => "processing",
                AssetHlsStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetHlsStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AssetHlsStatus.Error,
                "pending" => AssetHlsStatus.Pending,
                "processing" => AssetHlsStatus.Processing,
                "ready" => AssetHlsStatus.Ready,
                _ => null,
            };
        }
    }
}