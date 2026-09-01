#nullable enable

namespace TwelveLabs
{
    public partial interface IEmbedV2Client
    {
        /// <summary>
        /// Create sync embeddings<br/>
        /// This method synchronously creates embeddings for multimodal content and returns the results immediately in the response.<br/>
        /// Use this method to embed a query for retrieving matching content. With Marengo 3.5, audio and video can be up to 30 seconds. With Marengo 3.0, they can be up to 10 minutes. For longer content, use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task) method of the `/embed-v2/tasks` endpoint instead.<br/>
        /// The content this method accepts depends on the model. With Marengo 3.5, this method accepts only the `multi_input` input type; provide text, images, audio, or video as media sources. With Marengo 3.0, use the individual input types. For the formats, resolutions, file sizes, and duration limits each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This method is rate-limited. With Marengo 3.5, the platform counts input tokens for each type of content. A request can exceed a limit before you see an error. For details, see [Input token limits for embedding](/v1.3/docs/get-started/rate-limits#input-token-limits-for-embedding).<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EmbeddingSuccessResponse> CreateAsync(
            string xApiKey,

            global::TwelveLabs.CreateEmbeddingsRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create sync embeddings<br/>
        /// This method synchronously creates embeddings for multimodal content and returns the results immediately in the response.<br/>
        /// Use this method to embed a query for retrieving matching content. With Marengo 3.5, audio and video can be up to 30 seconds. With Marengo 3.0, they can be up to 10 minutes. For longer content, use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task) method of the `/embed-v2/tasks` endpoint instead.<br/>
        /// The content this method accepts depends on the model. With Marengo 3.5, this method accepts only the `multi_input` input type; provide text, images, audio, or video as media sources. With Marengo 3.0, use the individual input types. For the formats, resolutions, file sizes, and duration limits each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This method is rate-limited. With Marengo 3.5, the platform counts input tokens for each type of content. A request can exceed a limit before you see an error. For details, see [Input token limits for embedding](/v1.3/docs/get-started/rate-limits#input-token-limits-for-embedding).<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.EmbeddingSuccessResponse>> CreateAsResponseAsync(
            string xApiKey,

            global::TwelveLabs.CreateEmbeddingsRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create sync embeddings<br/>
        /// This method synchronously creates embeddings for multimodal content and returns the results immediately in the response.<br/>
        /// Use this method to embed a query for retrieving matching content. With Marengo 3.5, audio and video can be up to 30 seconds. With Marengo 3.0, they can be up to 10 minutes. For longer content, use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task) method of the `/embed-v2/tasks` endpoint instead.<br/>
        /// The content this method accepts depends on the model. With Marengo 3.5, this method accepts only the `multi_input` input type; provide text, images, audio, or video as media sources. With Marengo 3.0, use the individual input types. For the formats, resolutions, file sizes, and duration limits each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This method is rate-limited. With Marengo 3.5, the platform counts input tokens for each type of content. A request can exceed a limit before you see an error. For details, see [Input token limits for embedding](/v1.3/docs/get-started/rate-limits#input-token-limits-for-embedding).<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `multi_input`: Text and up to 10 media sources, combined into a single embedding. To reference a specific media source from your text, use a placeholder in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.<br/>
        /// - `audio`: An audio file. Requires Marengo 3.0.<br/>
        /// - `video`: A video file. Requires Marengo 3.0.<br/>
        /// - `image`: An image file. Requires Marengo 3.0.<br/>
        /// - `text`: Text input. Requires Marengo 3.0.<br/>
        /// - `text_image`: Text and an image. Requires Marengo 3.0.
        /// </param>
        /// <param name="modelName">
        /// The embedding model to use.<br/>
        /// **Values**:<br/>
        /// - `marengo3.5`: For details about this version, see the [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5) page.<br/>
        /// - `marengo3.0`: For details about this version, see the [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0) page.<br/>
        /// Default Value: marengo3.0
        /// </param>
        /// <param name="autoTruncate">
        /// Controls the behavior of the platform when the text in your request exceeds 2,000 tokens. Requires Marengo 3.5.<br/>
        /// **Values**:<br/>
        /// - `false`: Return a `400` error.<br/>
        /// - `true`: Truncate your text to fit the limit, and set the [`usage.truncated`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#response.body.usage.truncated) field to `true` in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="embeddingUncertainty">
        /// Set this parameter to `true` to receive a [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#response.body.data.embedding-uncertainty) field in the response, representing a per-dimension uncertainty vector with the same length as the `embedding` array. A higher value shows lower confidence in that dimension. Requires Marengo 3.5.<br/>
        /// Set this parameter to `true` only when your request embeds text only, or media only. Requests that combine text with media sources return a `400` error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="text">
        /// This field is required if the `input_type` parameter is `text`.
        /// </param>
        /// <param name="image">
        /// This field is required if the `input_type` parameter is `image`.
        /// </param>
        /// <param name="textImage">
        /// This field is required if the `input_type` parameter is `text_image`.
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.
        /// </param>
        /// <param name="multiInput">
        /// This field is required if the `input_type` parameter is `multi_input`. It combines text and up to 10 media sources into a single embedding. Provide the `input_text` field, the `media_sources` field, or both.<br/>
        /// Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.<br/>
        /// Include text in the `input_text` field when you combine media sources of different types. For example, a request that combines an image and a video returns a `400` error without text. Media sources of the same type do not require text.<br/>
        /// With Marengo 3.5, the text cannot exceed 2,000 tokens. Media sources do not count toward this limit. Use the `auto_truncate` parameter to control the behavior of the platform when your text exceeds it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EmbeddingSuccessResponse> CreateAsync(
            string xApiKey,
            global::TwelveLabs.CreateEmbeddingsRequestInputType inputType,
            global::TwelveLabs.CreateEmbeddingsRequestModelName modelName = global::TwelveLabs.CreateEmbeddingsRequestModelName.Marengo30,
            bool? autoTruncate = default,
            bool? embeddingUncertainty = default,
            global::TwelveLabs.TextInputRequest? text = default,
            global::TwelveLabs.ImageInputRequest? image = default,
            global::TwelveLabs.TextImageInputRequest? textImage = default,
            global::TwelveLabs.AudioInputRequest? audio = default,
            global::TwelveLabs.VideoInputRequest? video = default,
            global::TwelveLabs.MultiInputRequest? multiInput = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}