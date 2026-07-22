
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A single import of files from a connected account. An import does not change after it is created.
    /// </summary>
    public sealed partial class Import
    {
        /// <summary>
        /// The unique identifier of the import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The unique identifier of the connection the files were imported through.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// The data connector provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ImportProviderJsonConverter))]
        public global::TwelveLabs.ImportProvider? Provider { get; set; }

        /// <summary>
        /// The label you supplied when creating the connection, copied when the import was created. Present only when a value is set for the `custom_id` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// The number of files requested in this import. If an imported asset is later deleted, it is omitted from the `items` array in the Retrieve an import response, so the `items` array can contain fewer entries than `item_count`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int? ItemCount { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the import was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Import" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the import.
        /// </param>
        /// <param name="connectionId">
        /// The unique identifier of the connection the files were imported through.
        /// </param>
        /// <param name="provider">
        /// The data connector provider.
        /// </param>
        /// <param name="customId">
        /// The label you supplied when creating the connection, copied when the import was created. Present only when a value is set for the `custom_id` field.
        /// </param>
        /// <param name="itemCount">
        /// The number of files requested in this import. If an imported asset is later deleted, it is omitted from the `items` array in the Retrieve an import response, so the `items` array can contain fewer entries than `item_count`.
        /// </param>
        /// <param name="createdAt">
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the import was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Import(
            string? id,
            string? connectionId,
            global::TwelveLabs.ImportProvider? provider,
            string? customId,
            int? itemCount,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.ConnectionId = connectionId;
            this.Provider = provider;
            this.CustomId = customId;
            this.ItemCount = itemCount;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Import" /> class.
        /// </summary>
        public Import()
        {
        }

    }
}