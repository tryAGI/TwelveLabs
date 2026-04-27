
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The AI model to use for generating the response.
    /// </summary>
    public enum ResponseCreateRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Jockey10,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCreateRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCreateRequestModel value)
        {
            return value switch
            {
                ResponseCreateRequestModel.Jockey10 => "jockey1.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCreateRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jockey1.0" => ResponseCreateRequestModel.Jockey10,
                _ => null,
            };
        }
    }
}