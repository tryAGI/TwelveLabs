
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAsyncAnalyzeRequestMaxTokens1
    {
        /// <summary>
        ///
        /// </summary>
        Unlimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAsyncAnalyzeRequestMaxTokens1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAsyncAnalyzeRequestMaxTokens1 value)
        {
            return value switch
            {
                CreateAsyncAnalyzeRequestMaxTokens1.Unlimited => "unlimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAsyncAnalyzeRequestMaxTokens1? ToEnum(string value)
        {
            return value switch
            {
                "unlimited" => CreateAsyncAnalyzeRequestMaxTokens1.Unlimited,
                _ => null,
            };
        }
    }
}