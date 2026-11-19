
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Thumbnail details for the asset. Present only when thumbnail generation has been requested. PDF files use the first page for the representative thumbnail; text and Markdown files do not produce thumbnails.
    /// </summary>
    public sealed partial class AssetThumbnail
    {
        /// <summary>
        /// The URL of the representative thumbnail image. Only present when the status of the thumbnail is `ready`. The signed URL is valid for at least 1 hour and up to 2 hours. A request for the thumbnail after the URL expires returns a `403` error. Call the method that returned the URL again for a new URL instead of storing it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("representative_url")]
        public string? RepresentativeUrl { get; set; }

        /// <summary>
        /// The status of the thumbnail.<br/>
        /// **Values**:<br/>
        /// - `pending`: The platform has not yet started thumbnail generation<br/>
        /// - `processing`: The platform is generating the thumbnail<br/>
        /// - `ready`: The thumbnail is ready<br/>
        /// - `error`: Thumbnail generation failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AssetThumbnailStatusJsonConverter))]
        public global::TwelveLabs.AssetThumbnailStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetThumbnail" /> class.
        /// </summary>
        /// <param name="representativeUrl">
        /// The URL of the representative thumbnail image. Only present when the status of the thumbnail is `ready`. The signed URL is valid for at least 1 hour and up to 2 hours. A request for the thumbnail after the URL expires returns a `403` error. Call the method that returned the URL again for a new URL instead of storing it.
        /// </param>
        /// <param name="status">
        /// The status of the thumbnail.<br/>
        /// **Values**:<br/>
        /// - `pending`: The platform has not yet started thumbnail generation<br/>
        /// - `processing`: The platform is generating the thumbnail<br/>
        /// - `ready`: The thumbnail is ready<br/>
        /// - `error`: Thumbnail generation failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetThumbnail(
            string? representativeUrl,
            global::TwelveLabs.AssetThumbnailStatus? status)
        {
            this.RepresentativeUrl = representativeUrl;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetThumbnail" /> class.
        /// </summary>
        public AssetThumbnail()
        {
        }

    }
}