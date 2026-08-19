
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The video understanding model to enable for this index.<br/>
    /// - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
    /// &lt;Note title="Note"&gt;<br/>
    /// You cannot change the model configuration once the index has been created.<br/>
    /// &lt;/Note&gt;
    /// </summary>
    public enum IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName
    {
        /// <summary>
        /// Enhanced model with sports intelligence and extended content support.
        /// </summary>
        Marengo30,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName value)
        {
            return value switch
            {
                IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName.Marengo30 => "marengo3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName? ToEnum(string value)
        {
            return value switch
            {
                "marengo3.0" => IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName.Marengo30,
                _ => null,
            };
        }
    }
}