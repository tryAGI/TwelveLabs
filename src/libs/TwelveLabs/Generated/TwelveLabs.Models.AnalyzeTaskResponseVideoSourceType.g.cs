
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of video source.
    /// </summary>
    public enum AnalyzeTaskResponseVideoSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        AssetId,
        /// <summary>
        /// 
        /// </summary>
        Base64String,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        VideoId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyzeTaskResponseVideoSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeTaskResponseVideoSourceType value)
        {
            return value switch
            {
                AnalyzeTaskResponseVideoSourceType.AssetId => "asset_id",
                AnalyzeTaskResponseVideoSourceType.Base64String => "base64_string",
                AnalyzeTaskResponseVideoSourceType.Url => "url",
                AnalyzeTaskResponseVideoSourceType.VideoId => "video_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeTaskResponseVideoSourceType? ToEnum(string value)
        {
            return value switch
            {
                "asset_id" => AnalyzeTaskResponseVideoSourceType.AssetId,
                "base64_string" => AnalyzeTaskResponseVideoSourceType.Base64String,
                "url" => AnalyzeTaskResponseVideoSourceType.Url,
                "video_id" => AnalyzeTaskResponseVideoSourceType.VideoId,
                _ => null,
            };
        }
    }
}