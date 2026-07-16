
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Options that control how videos are matched. By default, videos are matched on their visual content.
    /// </summary>
    public sealed partial class VideoSearchOptions
    {
        /// <summary>
        /// The video modalities used for searching.<br/>
        /// Available options:<br/>
        /// - `visual`: Searches visual content.<br/>
        /// - `audio`: Searches audio content, including speech and non-speech sounds.<br/>
        /// You can combine multiple modalities to broaden your search. For example, to search both visual content and audio, set the `modalities` parameter to `["visual", "audio"]`.<br/>
        /// For guidance, see [Search options](/v1.3/docs/concepts/modalities#search-options).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality> Modalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchOptions" /> class.
        /// </summary>
        /// <param name="modalities">
        /// The video modalities used for searching.<br/>
        /// Available options:<br/>
        /// - `visual`: Searches visual content.<br/>
        /// - `audio`: Searches audio content, including speech and non-speech sounds.<br/>
        /// You can combine multiple modalities to broaden your search. For example, to search both visual content and audio, set the `modalities` parameter to `["visual", "audio"]`.<br/>
        /// For guidance, see [Search options](/v1.3/docs/concepts/modalities#search-options).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSearchOptions(
            global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality> modalities)
        {
            this.Modalities = modalities ?? throw new global::System.ArgumentNullException(nameof(modalities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchOptions" /> class.
        /// </summary>
        public VideoSearchOptions()
        {
        }

    }
}