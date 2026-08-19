
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems
    {
        /// <summary>
        /// The video understanding model to enable for this index.<br/>
        /// - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// You cannot change the model configuration once the index has been created.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelNameJsonConverter))]
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName ModelName { get; set; }

        /// <summary>
        /// An array that specifies which modalities the platform analyzes. For the Marengo model, you can specify one or both of the following model options: `visual` and `audio`. For more details, see the [Model options](/v1.3/docs/concepts/modalities#model-options) section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ModelOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems" /> class.
        /// </summary>
        /// <param name="modelOptions">
        /// An array that specifies which modalities the platform analyzes. For the Marengo model, you can specify one or both of the following model options: `visual` and `audio`. For more details, see the [Model options](/v1.3/docs/concepts/modalities#model-options) section.
        /// </param>
        /// <param name="modelName">
        /// The video understanding model to enable for this index.<br/>
        /// - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// You cannot change the model configuration once the index has been created.<br/>
        /// &lt;/Note&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems(
            global::System.Collections.Generic.IList<string> modelOptions,
            global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName modelName)
        {
            this.ModelName = modelName;
            this.ModelOptions = modelOptions ?? throw new global::System.ArgumentNullException(nameof(modelOptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems" /> class.
        /// </summary>
        public IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems()
        {
        }

    }
}