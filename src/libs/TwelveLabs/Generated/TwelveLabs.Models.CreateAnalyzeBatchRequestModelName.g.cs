
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The video understanding model to use for every item in this batch. Batch analysis requires Pegasus 1.5.
    /// </summary>
    public enum CreateAnalyzeBatchRequestModelName
    {
        /// <summary>
        /// 
        /// </summary>
        Pegasus15,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAnalyzeBatchRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnalyzeBatchRequestModelName value)
        {
            return value switch
            {
                CreateAnalyzeBatchRequestModelName.Pegasus15 => "pegasus1.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnalyzeBatchRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "pegasus1.5" => CreateAnalyzeBatchRequestModelName.Pegasus15,
                _ => null,
            };
        }
    }
}