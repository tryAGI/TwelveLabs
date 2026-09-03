
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The object type, always `response`. It has the same value as the `type`<br/>
    /// field.<br/>
    /// Only the response itself has an `object` field. Output items, annotations,<br/>
    /// and stream events are identified by `type` alone and have no `object` field.
    /// </summary>
    public enum ResponseObjectObject
    {
        /// <summary>
        ///
        /// </summary>
        Response,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseObjectObject value)
        {
            return value switch
            {
                ResponseObjectObject.Response => "response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "response" => ResponseObjectObject.Response,
                _ => null,
            };
        }
    }
}