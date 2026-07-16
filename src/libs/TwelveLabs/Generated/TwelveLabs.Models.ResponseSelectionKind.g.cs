
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of resource to select.<br/>
    /// **Values**:<br/>
    /// - `item`: A single knowledge store item.<br/>
    /// - `collection`: A knowledge store item collection. All items in the collection are included in the request.
    /// </summary>
    public enum ResponseSelectionKind
    {
        /// <summary>
        /// A knowledge store item collection. All items in the collection are included in the request.
        /// </summary>
        Collection,
        /// <summary>
        /// A single knowledge store item.
        /// </summary>
        Item,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSelectionKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSelectionKind value)
        {
            return value switch
            {
                ResponseSelectionKind.Collection => "collection",
                ResponseSelectionKind.Item => "item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSelectionKind? ToEnum(string value)
        {
            return value switch
            {
                "collection" => ResponseSelectionKind.Collection,
                "item" => ResponseSelectionKind.Item,
                _ => null,
            };
        }
    }
}