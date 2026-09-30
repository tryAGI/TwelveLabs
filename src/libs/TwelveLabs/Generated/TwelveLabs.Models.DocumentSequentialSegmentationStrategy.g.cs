
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The strategy for dividing the text into chunks. Always `sentence`, which groups whole sentences into each chunk, up to the number of sentences in the `max_sentences` field.
    /// </summary>
    public enum DocumentSequentialSegmentationStrategy
    {
        /// <summary>
        ///
        /// </summary>
        Sentence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentSequentialSegmentationStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentSequentialSegmentationStrategy value)
        {
            return value switch
            {
                DocumentSequentialSegmentationStrategy.Sentence => "sentence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentSequentialSegmentationStrategy? ToEnum(string value)
        {
            return value switch
            {
                "sentence" => DocumentSequentialSegmentationStrategy.Sentence,
                _ => null,
            };
        }
    }
}