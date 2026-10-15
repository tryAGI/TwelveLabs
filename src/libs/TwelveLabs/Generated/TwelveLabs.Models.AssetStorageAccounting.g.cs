
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The storage accounting setting of an asset.
    /// </summary>
    public sealed partial class AssetStorageAccounting
    {
        /// <summary>
        /// The unique identifier of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// Indicates whether the platform counts the asset toward your Managed Intelligence allowance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_accounting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool StorageAccounting { get; set; }

        /// <summary>
        /// The number of stored bytes that the platform counts for the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Bytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetStorageAccounting" /> class.
        /// </summary>
        /// <param name="assetId">
        /// The unique identifier of the asset.
        /// </param>
        /// <param name="storageAccounting">
        /// Indicates whether the platform counts the asset toward your Managed Intelligence allowance.
        /// </param>
        /// <param name="bytes">
        /// The number of stored bytes that the platform counts for the asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetStorageAccounting(
            string assetId,
            bool storageAccounting,
            long bytes)
        {
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.StorageAccounting = storageAccounting;
            this.Bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetStorageAccounting" /> class.
        /// </summary>
        public AssetStorageAccounting()
        {
        }

    }
}