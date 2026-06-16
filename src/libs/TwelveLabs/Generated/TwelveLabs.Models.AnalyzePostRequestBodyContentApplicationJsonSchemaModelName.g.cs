
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The video understanding model to use for analysis.<br/>
    /// - `pegasus1.2`: General analysis (prompt-based text generation).<br/>
    /// - `pegasus1.5`: General analysis (prompt-based text generation) with video clipping, structured prompts with reference images, and video segmentation (async only). See the [Pegasus](/v1.3/docs/concepts/models/pegasus#context-window) page for token limits.<br/>
    /// **Default:** `pegasus1.2`<br/>
    /// Default Value: pegasus1.2
    /// </summary>
    public enum AnalyzePostRequestBodyContentApplicationJsonSchemaModelName
    {
        /// <summary>
        /// General analysis (prompt-based text generation).
        /// </summary>
        Pegasus12,
        /// <summary>
        /// General analysis (prompt-based text generation) with video clipping, structured prompts with reference images, and video segmentation (async only). See the [Pegasus](/v1.3/docs/concepts/models/pegasus#context-window) page for token limits.
        /// </summary>
        Pegasus15,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyzePostRequestBodyContentApplicationJsonSchemaModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzePostRequestBodyContentApplicationJsonSchemaModelName value)
        {
            return value switch
            {
                AnalyzePostRequestBodyContentApplicationJsonSchemaModelName.Pegasus12 => "pegasus1.2",
                AnalyzePostRequestBodyContentApplicationJsonSchemaModelName.Pegasus15 => "pegasus1.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzePostRequestBodyContentApplicationJsonSchemaModelName? ToEnum(string value)
        {
            return value switch
            {
                "pegasus1.2" => AnalyzePostRequestBodyContentApplicationJsonSchemaModelName.Pegasus12,
                "pegasus1.5" => AnalyzePostRequestBodyContentApplicationJsonSchemaModelName.Pegasus15,
                _ => null,
            };
        }
    }
}