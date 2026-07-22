
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Describes where an asset came from. The platform sets this field for assets imported through a connector; it is absent for assets uploaded directly to the `/assets` endpoint.
    /// </summary>
    public sealed partial class AssetSource
    {
        /// <summary>
        /// The kind of source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AssetSourceTypeJsonConverter))]
        public global::TwelveLabs.AssetSourceType? Type { get; set; }

        /// <summary>
        /// Provider-specific details about the origin of the file. The fields depend on the value of the `type` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::TwelveLabs.AssetSourceDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The kind of source.
        /// </param>
        /// <param name="details">
        /// Provider-specific details about the origin of the file. The fields depend on the value of the `type` field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetSource(
            global::TwelveLabs.AssetSourceType? type,
            global::TwelveLabs.AssetSourceDetails? details)
        {
            this.Type = type;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetSource" /> class.
        /// </summary>
        public AssetSource()
        {
        }

    }
}