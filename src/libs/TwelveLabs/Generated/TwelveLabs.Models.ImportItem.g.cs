
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An import item, including the `action` value and the current status of its asset. The `action` field does not change. The `status` field reflects the current status of the asset. An item rejected before an asset was created has no value in its `status` field; its `error` object describes the reason instead.
    /// </summary>
    public sealed partial class ImportItem
    {
        /// <summary>
        /// The identifier of the file at the provider. For Google Drive, this is the identifier Google Drive assigns to the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        public string? SourceId { get; set; }

        /// <summary>
        /// The action taken for this file: created, skipped, retried, or rejected. The platform sets this value while processing the request, and the value does not change afterward. The [Import files](/v1.3/api-reference/data-connectors/imports/import-files) endpoint always returns this field. The [Retrieve an import](/v1.3/api-reference/data-connectors/imports/retrieve-an-import) endpoint omits it for imports from before this field existed. Treat an absent value as unknown rather than as a specific action.<br/>
        /// The `skipped` and `retried` values both mean the file was already imported through this account: for the `skipped` action, the platform returns the existing asset; for the `retried` action, the earlier fetch had failed, so the platform fetches the file again. See [The import object](/v1.3/api-reference/data-connectors/imports/the-import-object#item-actions) for the meaning of each value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ImportItemActionJsonConverter))]
        public global::TwelveLabs.ImportItemAction? Action { get; set; }

        /// <summary>
        /// The unique identifier of the asset for this file. When the `action` field is `created`, this identifies a new asset; when it is `skipped` or `retried`, this identifies the asset from the earlier import of the same file. Absent when the item was rejected before an asset was created.
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
        /// The identifier of the file at the provider. For Google Drive, this is the identifier Google Drive assigns to the file.
        /// </param>
        /// <param name="action">
        /// The action taken for this file: created, skipped, retried, or rejected. The platform sets this value while processing the request, and the value does not change afterward. The [Import files](/v1.3/api-reference/data-connectors/imports/import-files) endpoint always returns this field. The [Retrieve an import](/v1.3/api-reference/data-connectors/imports/retrieve-an-import) endpoint omits it for imports from before this field existed. Treat an absent value as unknown rather than as a specific action.<br/>
        /// The `skipped` and `retried` values both mean the file was already imported through this account: for the `skipped` action, the platform returns the existing asset; for the `retried` action, the earlier fetch had failed, so the platform fetches the file again. See [The import object](/v1.3/api-reference/data-connectors/imports/the-import-object#item-actions) for the meaning of each value.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of the asset for this file. When the `action` field is `created`, this identifies a new asset; when it is `skipped` or `retried`, this identifies the asset from the earlier import of the same file. Absent when the item was rejected before an asset was created.
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
            global::TwelveLabs.ImportItemAction? action,
            string? assetId,
            global::TwelveLabs.ImportItemStatus? status,
            global::TwelveLabs.ImportItemError? error)
        {
            this.SourceId = sourceId;
            this.Action = action;
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