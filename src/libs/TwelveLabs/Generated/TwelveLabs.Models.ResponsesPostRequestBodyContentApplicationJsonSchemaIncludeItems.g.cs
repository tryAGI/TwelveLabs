
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems
    {
        /// <summary>
        ///
        /// </summary>
        IntermediateOutputs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems value)
        {
            return value switch
            {
                ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems.IntermediateOutputs => "intermediate_outputs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems? ToEnum(string value)
        {
            return value switch
            {
                "intermediate_outputs" => ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems.IntermediateOutputs,
                _ => null,
            };
        }
    }
}