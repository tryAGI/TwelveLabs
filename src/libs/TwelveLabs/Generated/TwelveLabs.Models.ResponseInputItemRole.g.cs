
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The role of the message author. Only `user` is currently supported.<br/>
    /// Additional roles may be added in the future.
    /// </summary>
    public enum ResponseInputItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInputItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputItemRole value)
        {
            return value switch
            {
                ResponseInputItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputItemRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseInputItemRole.User,
                _ => null,
            };
        }
    }
}