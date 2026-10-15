
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results to the moments and ranges that matching tags mark on video items. A tag matches when its `tag_metadata` field matches the `metadata` field. Only video items have tags, so images do not appear in the results.<br/>
    /// The search returns only the clips within a matching tag:<br/>
    /// - For a tag on a range, a clip matches when it lies entirely within the range. A clip that extends past either end of the range does not appear in the results.<br/>
    /// - For a tag on a single moment, a clip matches when it contains that moment.<br/>
    /// A clip within more than one matching tag appears once. With the `group_by` parameter set to `item`, each item groups only its clips within matching tags. When you specify other fields of the filter, a tag counts only when its item matches every other field. The `asset_type` field does not reduce the count. If more than 100 tags match, the platform returns a `422` error with the `metadata_filter_too_broad` code.<br/>
    /// To tag a moment or a range of a video item, use the [`POST`](/v1.3/api-reference/knowledge-store-items/item-tags/create) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/tags` endpoint.
    /// </summary>
    public sealed partial class TagFilter
    {
        /// <summary>
        /// The metadata to match against the `tag_metadata` field of each tag. Map each key to an object with exactly one of `eq` or `in`. Specify 1 to 50 keys. When you specify more than one key, every key must match on the same tag.<br/>
        /// A value is a string, a number, or a boolean. The platform matches it with the JSON type the tag stores, so `2026` does not match a tag that stores `"2026"`. A key that stores a list matches when the list contains the value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.MetadataValueFilter> Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagFilter" /> class.
        /// </summary>
        /// <param name="metadata">
        /// The metadata to match against the `tag_metadata` field of each tag. Map each key to an object with exactly one of `eq` or `in`. Specify 1 to 50 keys. When you specify more than one key, every key must match on the same tag.<br/>
        /// A value is a string, a number, or a boolean. The platform matches it with the JSON type the tag stores, so `2026` does not match a tag that stores `"2026"`. A key that stores a list matches when the list contains the value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TagFilter(
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.MetadataValueFilter> metadata)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagFilter" /> class.
        /// </summary>
        public TagFilter()
        {
        }

    }
}