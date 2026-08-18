
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Provider-specific details about the origin of the file. The fields depend on the value of the `type` field.
    /// </summary>
    public sealed partial class AssetSourceDetails
    {
        /// <summary>
        /// The data connector provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AssetSourceDetailsProviderJsonConverter))]
        public global::TwelveLabs.AssetSourceDetailsProvider? Provider { get; set; }

        /// <summary>
        /// The identifier of the file at the provider. For Google Drive, this is the identifier Google Drive assigns to the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        public string? SourceId { get; set; }

        /// <summary>
        /// The name of the file at the provider when it was imported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_filename")]
        public string? OriginalFilename { get; set; }

        /// <summary>
        /// A link to the file at the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_link")]
        public string? SourceLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetSourceDetails" /> class.
        /// </summary>
        /// <param name="provider">
        /// The data connector provider.
        /// </param>
        /// <param name="sourceId">
        /// The identifier of the file at the provider. For Google Drive, this is the identifier Google Drive assigns to the file.
        /// </param>
        /// <param name="originalFilename">
        /// The name of the file at the provider when it was imported.
        /// </param>
        /// <param name="sourceLink">
        /// A link to the file at the provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetSourceDetails(
            global::TwelveLabs.AssetSourceDetailsProvider? provider,
            string? sourceId,
            string? originalFilename,
            string? sourceLink)
        {
            this.Provider = provider;
            this.SourceId = sourceId;
            this.OriginalFilename = originalFilename;
            this.SourceLink = sourceLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetSourceDetails" /> class.
        /// </summary>
        public AssetSourceDetails()
        {
        }

    }
}