
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The element type for an `array` field. Required when `type` is `array`; not supported on any other type.
    /// </summary>
    public sealed partial class TimeArrayItemFieldItems
    {
        /// <summary>
        /// The type of the array elements. It must be a scalar (`string`, `number`, `boolean`, or `integer`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.TimeArrayItemFieldItemsTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.TimeArrayItemFieldItemsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeArrayItemFieldItems" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the array elements. It must be a scalar (`string`, `number`, `boolean`, or `integer`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeArrayItemFieldItems(
            global::TwelveLabs.TimeArrayItemFieldItemsType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeArrayItemFieldItems" /> class.
        /// </summary>
        public TimeArrayItemFieldItems()
        {
        }

    }
}