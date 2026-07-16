
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoContextDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AssetId,
        /// <summary>
        /// 
        /// </summary>
        Base64String,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoContextDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoContextDiscriminatorType value)
        {
            return value switch
            {
                VideoContextDiscriminatorType.AssetId => "asset_id",
                VideoContextDiscriminatorType.Base64String => "base64_string",
                VideoContextDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoContextDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "asset_id" => VideoContextDiscriminatorType.AssetId,
                "base64_string" => VideoContextDiscriminatorType.Base64String,
                "url" => VideoContextDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}