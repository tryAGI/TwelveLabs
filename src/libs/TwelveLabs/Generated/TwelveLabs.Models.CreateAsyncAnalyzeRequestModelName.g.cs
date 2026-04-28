
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The video understanding model to use for analysis.<br/>
    /// - `pegasus1.2`: Analyzes pre-indexed videos. Provide the `video_id` of your pre-indexed video.<br/>
    /// - `pegasus1.5`: Analyzes videos directly from a URL, asset, or base64 string. Supports both general analysis and video segmentation with custom segment definitions.<br/>
    /// **Default:** `pegasus1.2`<br/>
    /// Default Value: pegasus1.2
    /// </summary>
    public enum CreateAsyncAnalyzeRequestModelName
    {
        /// <summary>
        /// Analyzes pre-indexed videos. Provide the `video_id` of your pre-indexed video.
        /// </summary>
        Pegasus12,
        /// <summary>
        /// Analyzes videos directly from a URL, asset, or base64 string. Supports both general analysis and video segmentation with custom segment definitions.
        /// </summary>
        Pegasus15,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAsyncAnalyzeRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAsyncAnalyzeRequestModelName value)
        {
            return value switch
            {
                CreateAsyncAnalyzeRequestModelName.Pegasus12 => "pegasus1.2",
                CreateAsyncAnalyzeRequestModelName.Pegasus15 => "pegasus1.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAsyncAnalyzeRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "pegasus1.2" => CreateAsyncAnalyzeRequestModelName.Pegasus12,
                "pegasus1.5" => CreateAsyncAnalyzeRequestModelName.Pegasus15,
                _ => null,
            };
        }
    }
}