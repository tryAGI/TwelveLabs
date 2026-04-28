
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The JSON schema for this task. Present only when `type` is `json_schema`.<br/>
    /// - [List](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks): Omitted.<br/>
    /// - [Retrieve](/v1.3/api-reference/analyze-videos/retrieve-analysis-task): Returns the full schema.
    /// </summary>
    public sealed partial class AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}