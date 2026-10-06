
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyzeTaskResponseRequestParamsMaxTokens1
    {
        /// <summary>
        ///
        /// </summary>
        Unlimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyzeTaskResponseRequestParamsMaxTokens1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeTaskResponseRequestParamsMaxTokens1 value)
        {
            return value switch
            {
                AnalyzeTaskResponseRequestParamsMaxTokens1.Unlimited => "unlimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeTaskResponseRequestParamsMaxTokens1? ToEnum(string value)
        {
            return value switch
            {
                "unlimited" => AnalyzeTaskResponseRequestParamsMaxTokens1.Unlimited,
                _ => null,
            };
        }
    }
}