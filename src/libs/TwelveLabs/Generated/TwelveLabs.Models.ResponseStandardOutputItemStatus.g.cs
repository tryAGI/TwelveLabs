
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The lifecycle status of the output item.
    /// </summary>
    public enum ResponseStandardOutputItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStandardOutputItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStandardOutputItemStatus value)
        {
            return value switch
            {
                ResponseStandardOutputItemStatus.Completed => "completed",
                ResponseStandardOutputItemStatus.InProgress => "in_progress",
                ResponseStandardOutputItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStandardOutputItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponseStandardOutputItemStatus.Completed,
                "in_progress" => ResponseStandardOutputItemStatus.InProgress,
                "incomplete" => ResponseStandardOutputItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}