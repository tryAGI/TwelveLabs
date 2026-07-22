
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An import item and the current status of its asset. An item rejected before an asset was created has no value in its `status` field; its `error` object describes the reason instead.
    /// </summary>
    public sealed partial class ImportItem
    {
        /// <summary>
        /// The identifier of the file at the provider. For Google Drive, this is the Drive file identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        public string? SourceId { get; set; }

        /// <summary>
        /// The unique identifier of the asset created for this file. Absent when the item was rejected before an asset was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// The status of the asset. See [The import object](/v1.3/api-reference/data-connectors/imports/the-import-object#item-statuses) for the possible values. Absent when the item was rejected before an asset was created, in which case an `error` object is present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ImportItemStatusJsonConverter))]
        public global::TwelveLabs.ImportItemStatus? Status { get; set; }

        /// <summary>
        /// Details of the rejection. Present when the item was rejected before an asset was created, in which case the `status` field is absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::TwelveLabs.ImportItemError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportItem" /> class.
        /// </summary>
        /// <param name="sourceId">
        /// The identifier of the file at the provider. For Google Drive, this is the Drive file identifier.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of the asset created for this file. Absent when the item was rejected before an asset was created.
        /// </param>
        /// <param name="status">
        /// The status of the asset. See [The import object](/v1.3/api-reference/data-connectors/imports/the-import-object#item-statuses) for the possible values. Absent when the item was rejected before an asset was created, in which case an `error` object is present.
        /// </param>
        /// <param name="error">
        /// Details of the rejection. Present when the item was rejected before an asset was created, in which case the `status` field is absent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportItem(
            string? sourceId,
            string? assetId,
            global::TwelveLabs.ImportItemStatus? status,
            global::TwelveLabs.ImportItemError? error)
        {
            this.SourceId = sourceId;
            this.AssetId = assetId;
            this.Status = status;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportItem" /> class.
        /// </summary>
        public ImportItem()
        {
        }

    }
}