
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results by enrichment values. The platform extracts these values as the enrichment configuration of the knowledge store defines (the `ingestion_config.enrichment_config` field).<br/>
    /// Map each top-level property that the enrichment configuration defines to an object with exactly one of the `eq` or `in` operators. You can specify 1 to 50 keys. If you specify a key that the enrichment configuration does not define, the platform returns a `400` error.<br/>
    /// The `granularity` keyword of a property sets how often the platform extracts its value. The keyword also sets which items the key matches:<br/>
    /// - `video`: One value for each video. The key matches video items only.<br/>
    /// - `image`: One value for each image. The key matches image items only.<br/>
    /// - `shot`: One value for each shot of a video. A shot is a continuous part of a video between two scene changes. The key matches video items only. If you specify more than one `shot` key, one shot must have all of the values. For example, a filter with the keys `topic` and `sentiment` at the `shot` granularity matches a video only when one shot has both values.<br/>
    /// An item must match all of the keys that you specify. A filter with a `video` key and an `image` key matches no items, because an item is a video or an image.<br/>
    /// Use the filter to choose which items to search. The search can return any clip of a matching item, including clips that do not match the filter.
    /// </summary>
    public sealed partial class EnrichmentFilter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}