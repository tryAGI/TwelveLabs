
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The embedding model to use.<br/>
    /// **Values**:<br/>
    /// - `marengo3.5`: For details about this version, see the [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5) page.<br/>
    /// - `marengo3.0`: For details about this version, see the [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0) page.<br/>
    /// Default Value: marengo3.0
    /// </summary>
    public enum CreateEmbeddingsRequestModelName
    {
        /// <summary>
        /// For details about this version, see the [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0) page.
        /// </summary>
        Marengo30,
        /// <summary>
        /// For details about this version, see the [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5) page.
        /// </summary>
        Marengo35,
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
                CreateEmbeddingsRequestModelName.Marengo35 => "marengo3.5",
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
                "marengo3.5" => CreateEmbeddingsRequestModelName.Marengo35,
                _ => null,
            };
        }
    }
}