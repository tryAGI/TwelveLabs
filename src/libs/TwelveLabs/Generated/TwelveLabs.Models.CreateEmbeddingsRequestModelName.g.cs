
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The video understanding model to use. Value: "marengo3.0".<br/>
    /// Default Value: marengo3.0
    /// </summary>
    public enum CreateEmbeddingsRequestModelName
    {
        /// <summary>
        /// "marengo3.0".
        /// </summary>
        Marengo30,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingsRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingsRequestModelName value)
        {
            return value switch
            {
                CreateEmbeddingsRequestModelName.Marengo30 => "marengo3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingsRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "marengo3.0" => CreateEmbeddingsRequestModelName.Marengo30,
                _ => null,
            };
        }
    }
}