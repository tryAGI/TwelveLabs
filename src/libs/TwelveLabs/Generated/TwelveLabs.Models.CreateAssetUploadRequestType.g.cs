
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of asset you want to upload.
    /// </summary>
    public enum CreateAssetUploadRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssetUploadRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetUploadRequestType value)
        {
            return value switch
            {
                CreateAssetUploadRequestType.Audio => "audio",
                CreateAssetUploadRequestType.Image => "image",
                CreateAssetUploadRequestType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetUploadRequestType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateAssetUploadRequestType.Audio,
                "image" => CreateAssetUploadRequestType.Image,
                "video" => CreateAssetUploadRequestType.Video,
                _ => null,
            };
        }
    }
}