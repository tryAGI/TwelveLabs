
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// HLS streaming details for the asset. Present only when HLS generation has been requested. Omitted otherwise.
    /// </summary>
    public sealed partial class AssetHLS
    {
        /// <summary>
        /// The URL of the HLS manifest file for streaming. Only present when the status of the HLS stream is `ready`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_url")]
        public string? ManifestUrl { get; set; }

        /// <summary>
        /// The status of the HLS stream.<br/>
        /// **Values**:<br/>
        /// - `pending`: The platform has not yet started HLS generation<br/>
        /// - `processing`: The platform is generating HLS segments<br/>
        /// - `ready`: The HLS stream is ready for playback<br/>
        /// - `error`: HLS generation failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AssetHlsStatusJsonConverter))]
        public global::TwelveLabs.AssetHlsStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetHLS" /> class.
        /// </summary>
        /// <param name="manifestUrl">
        /// The URL of the HLS manifest file for streaming. Only present when the status of the HLS stream is `ready`.
        /// </param>
        /// <param name="status">
        /// The status of the HLS stream.<br/>
        /// **Values**:<br/>
        /// - `pending`: The platform has not yet started HLS generation<br/>
        /// - `processing`: The platform is generating HLS segments<br/>
        /// - `ready`: The HLS stream is ready for playback<br/>
        /// - `error`: HLS generation failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetHLS(
            string? manifestUrl,
            global::TwelveLabs.AssetHlsStatus? status)
        {
            this.ManifestUrl = manifestUrl;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetHLS" /> class.
        /// </summary>
        public AssetHLS()
        {
        }
    }
}