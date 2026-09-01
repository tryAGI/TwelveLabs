
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// This field is required if the `input_type` parameter is `multi_input`. It combines text and up to 10 media sources into a single embedding. Provide the `input_text` field, the `media_sources` field, or both.<br/>
    /// Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.<br/>
    /// Include text in the `input_text` field when you combine media sources of different types. For example, a request that combines an image and a video returns a `400` error without text. Media sources of the same type do not require text.<br/>
    /// With Marengo 3.5, the text cannot exceed 2,000 tokens. Media sources do not count toward this limit. Use the `auto_truncate` parameter to control the behavior of the platform when your text exceeds it.
    /// </summary>
    public sealed partial class MultiInputRequest
    {
        /// <summary>
        /// Text to include in the embedding.<br/>
        /// **Usage options**:<br/>
        /// - Provide text without media sources to create a text-only embedding.<br/>
        /// - Combine text with media sources to add context. Example: "A person cooking."<br/>
        /// - Use media source references to describe relationships between specific media sources. The format is `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Example: "A person wearing &lt;@outfit&gt; and holding &lt;@accessory&gt;."<br/>
        /// - Omit this field to create an embedding from media sources only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        public string? InputText { get; set; }

        /// <summary>
        /// An array of up to 10 media sources to include in the embedding. Omit it to create a text-only embedding from the `input_text` field. The platform processes media sources in the order they appear in the array. If you use media source references in the [`input_text`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#request.body.multi_input.input_text) parameter, each must have a corresponding media source with a matching `name` field. If a reference has no match, the request fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_sources")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.MultiInputMediaSource>? MediaSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInputRequest" /> class.
        /// </summary>
        /// <param name="inputText">
        /// Text to include in the embedding.<br/>
        /// **Usage options**:<br/>
        /// - Provide text without media sources to create a text-only embedding.<br/>
        /// - Combine text with media sources to add context. Example: "A person cooking."<br/>
        /// - Use media source references to describe relationships between specific media sources. The format is `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Example: "A person wearing &lt;@outfit&gt; and holding &lt;@accessory&gt;."<br/>
        /// - Omit this field to create an embedding from media sources only.
        /// </param>
        /// <param name="mediaSources">
        /// An array of up to 10 media sources to include in the embedding. Omit it to create a text-only embedding from the `input_text` field. The platform processes media sources in the order they appear in the array. If you use media source references in the [`input_text`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#request.body.multi_input.input_text) parameter, each must have a corresponding media source with a matching `name` field. If a reference has no match, the request fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiInputRequest(
            string? inputText,
            global::System.Collections.Generic.IList<global::TwelveLabs.MultiInputMediaSource>? mediaSources)
        {
            this.InputText = inputText;
            this.MediaSources = mediaSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInputRequest" /> class.
        /// </summary>
        public MultiInputRequest()
        {
        }

    }
}