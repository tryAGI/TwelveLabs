
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The object type, always `response`. Carries the same value as `type`, which<br/>
    /// predates it and which the Open Responses specification does not name.<br/>
    /// Both fields are permanent; neither will be removed. Read whichever your client<br/>
    /// already uses.<br/>
    /// This is the only object with an `object` field. Output items, annotations and<br/>
    /// stream events are keyed on `type` alone, so do not expect `object` one level<br/>
    /// down.
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