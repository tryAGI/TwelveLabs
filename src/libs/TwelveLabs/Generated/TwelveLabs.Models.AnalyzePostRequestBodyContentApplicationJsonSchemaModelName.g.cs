
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The video understanding model to use for analysis.<br/>
    /// - `pegasus1.2`: General analysis (prompt-based text generation).<br/>
    /// - `pegasus1.5`: General analysis (prompt-based text generation) with video clipping, structured prompts with reference images, extended token limits, and video segmentation (async only). Does not support `analysis_mode=time_based_metadata` or `response_format.type=segment_definitions` — use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
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
        /// General analysis (prompt-based text generation) with video clipping, structured prompts with reference images, extended token limits, and video segmentation (async only). Does not support `analysis_mode=time_based_metadata` or `response_format.type=segment_definitions` — use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.
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