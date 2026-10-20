
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Match one key with `eq`, `in`, or inclusive `gte`/`lte` bounds. Equality and membership cannot be combined with ranges. Both range bounds must be numbers or both must be RFC 3339 timestamps with a timezone, and `gte` must not exceed `lte`.<br/>
    /// Numeric ranges match numeric scalars, excluding numeric strings and booleans. Date ranges compare instants, including timezone offsets. Missing values, malformed dates, nulls, and arrays do not match a range. A publication date stored in metadata can be filtered here; `created_at` filters creation time.
    /// </summary>
    public sealed partial class UserMetadataValueFilter
    {
        /// <summary>
        /// Match when the key has this value. The value must have the same type as the stored value for the key. For example, the number `2026` does not match the string `"2026"`. If the key holds a list, it matches when the list contains the value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eq")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.MetadataScalarValueJsonConverter))]
        public global::TwelveLabs.MetadataScalarValue? Eq { get; set; }

        /// <summary>
        /// Match when the key has any of these values. You can specify 1 to 100 values. Each value follows the rules for the `eq` operator. For example, `["tutorial", "guide"]` matches the value `tutorial` or `guide`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.MetadataScalarValue>? In { get; set; }

        /// <summary>
        /// Inclusive lower bound. Use a number or an RFC 3339 timestamp with a timezone, such as `2026-09-29T00:00:00Z` or `2026-09-29T09:00:00+09:00`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gte")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.MetadataRangeBoundJsonConverter))]
        public global::TwelveLabs.MetadataRangeBound? Gte { get; set; }

        /// <summary>
        /// Inclusive upper bound. Use a number or an RFC 3339 timestamp with a timezone, such as `2026-09-29T00:00:00Z` or `2026-09-29T09:00:00+09:00`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lte")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.MetadataRangeBoundJsonConverter))]
        public global::TwelveLabs.MetadataRangeBound? Lte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetadataValueFilter" /> class.
        /// </summary>
        /// <param name="eq">
        /// Match when the key has this value. The value must have the same type as the stored value for the key. For example, the number `2026` does not match the string `"2026"`. If the key holds a list, it matches when the list contains the value.
        /// </param>
        /// <param name="in">
        /// Match when the key has any of these values. You can specify 1 to 100 values. Each value follows the rules for the `eq` operator. For example, `["tutorial", "guide"]` matches the value `tutorial` or `guide`.
        /// </param>
        /// <param name="gte">
        /// Inclusive lower bound. Use a number or an RFC 3339 timestamp with a timezone, such as `2026-09-29T00:00:00Z` or `2026-09-29T09:00:00+09:00`.
        /// </param>
        /// <param name="lte">
        /// Inclusive upper bound. Use a number or an RFC 3339 timestamp with a timezone, such as `2026-09-29T00:00:00Z` or `2026-09-29T09:00:00+09:00`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMetadataValueFilter(
            global::TwelveLabs.MetadataScalarValue? eq,
            global::System.Collections.Generic.IList<global::TwelveLabs.MetadataScalarValue>? @in,
            global::TwelveLabs.MetadataRangeBound? gte,
            global::TwelveLabs.MetadataRangeBound? lte)
        {
            this.Eq = eq;
            this.In = @in;
            this.Gte = gte;
            this.Lte = lte;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetadataValueFilter" /> class.
        /// </summary>
        public UserMetadataValueFilter()
        {
        }

    }
}