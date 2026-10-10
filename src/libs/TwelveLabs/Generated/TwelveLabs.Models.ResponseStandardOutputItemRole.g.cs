
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The role of the message author. Present when `type` is `message`.
    /// </summary>
    public enum ResponseStandardOutputItemRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStandardOutputItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStandardOutputItemRole value)
        {
            return value switch
            {
                ResponseStandardOutputItemRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStandardOutputItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ResponseStandardOutputItemRole.Assistant,
                _ => null,
            };
        }
    }
}