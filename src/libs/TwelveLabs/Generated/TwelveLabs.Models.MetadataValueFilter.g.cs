
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results by the value of one key. Provide exactly one operator: `eq` to match one value, or `in` to match any of the listed values.
    /// </summary>
    public sealed partial class MetadataValueFilter
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataValueFilter" /> class.
        /// </summary>
        /// <param name="eq">
        /// Match when the key has this value. The value must have the same type as the stored value for the key. For example, the number `2026` does not match the string `"2026"`. If the key holds a list, it matches when the list contains the value.
        /// </param>
        /// <param name="in">
        /// Match when the key has any of these values. You can specify 1 to 100 values. Each value follows the rules for the `eq` operator. For example, `["tutorial", "guide"]` matches the value `tutorial` or `guide`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataValueFilter(
            global::TwelveLabs.MetadataScalarValue? eq,
            global::System.Collections.Generic.IList<global::TwelveLabs.MetadataScalarValue>? @in)
        {
            this.Eq = eq;
            this.In = @in;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataValueFilter" /> class.
        /// </summary>
        public MetadataValueFilter()
        {
        }

    }
}