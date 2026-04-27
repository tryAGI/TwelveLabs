
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseCreateRequestIncludeItems
    {
        /// <summary>
        /// 
        /// </summary>
        IntermediateOutputs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCreateRequestIncludeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCreateRequestIncludeItems value)
        {
            return value switch
            {
                ResponseCreateRequestIncludeItems.IntermediateOutputs => "intermediate_outputs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCreateRequestIncludeItems? ToEnum(string value)
        {
            return value switch
            {
                "intermediate_outputs" => ResponseCreateRequestIncludeItems.IntermediateOutputs,
                _ => null,
            };
        }
    }
}