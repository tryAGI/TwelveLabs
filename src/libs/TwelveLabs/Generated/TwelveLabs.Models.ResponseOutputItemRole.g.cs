
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The role of the message author. Present when `type` is `message`.
    /// </summary>
    public enum ResponseOutputItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputItemRole value)
        {
            return value switch
            {
                ResponseOutputItemRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ResponseOutputItemRole.Assistant,
                _ => null,
            };
        }
    }
}