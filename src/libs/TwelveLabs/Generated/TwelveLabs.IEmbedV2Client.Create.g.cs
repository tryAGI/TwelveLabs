#nullable enable

namespace TwelveLabs
{
    public partial interface IEmbedV2Client
    {
        /// <summary>
        /// Create sync embeddings<br/>
        /// This method synchronously creates embeddings for multimodal content and returns the results immediately in the response.<br/>
        /// Use this method to embed a query for retrieving matching content. With Marengo 3.5, audio and video can be up to 30 seconds. With Marengo 3.0, they can be up to 10 minutes. For longer content, use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task) method of the `/embed-v2/tasks` endpoint instead.<br/>
        /// The content this method accepts depends on the model. With Marengo 3.5, this method accepts only the `multi_input` input type; provide text, images, audio, video, or documents as media sources. With Marengo 3.0, use the individual input types. For the formats, resolutions, file sizes, and duration limits each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This method is rate-limited. With Marengo 3.5, the platform counts input tokens for each type of content. A request can exceed a limit before you see an error. For details, see [Input token limits for embedding](/v1.3/docs/get-started/rate-limits#input-token-limits-for-embedding).<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EmbeddingSuccessResponse> CreateAsync(

            global::TwelveLabs.CreateEmbeddingsRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create sync embeddings<br/>
        /// This method synchronously creates embeddings for multimodal content and returns the results immediately in the response.<br/>
        /// Use this method to embed a query for retrieving matching content. With Marengo 3.5, audio and video can be up to 30 seconds. With Marengo 3.0, they can be up to 10 minutes. For longer content, use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task) method of the `/embed-v2/tasks` endpoint instead.<br/>
        /// The content this method accepts depends on the model. With Marengo 3.5, this method accepts only the `multi_input` input type; provide text, images, audio, video, or documents as media sources. With Marengo 3.0, use the individual input types. For the formats, resolutions, file sizes, and duration limits each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This method is rate-limited. With Marengo 3.5, the platform counts input tokens for each type of content. A request can exceed a limit before you see an error. For details, see [Input token limits for embedding](/v1.3/docs/get-started/rate-limits#input-token-limits-for-embedding).<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.EmbeddingSuccessResponse>> CreateAsResponseAsync(

            global::TwelveLabs.CreateEmbeddingsRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create sync embeddings<br/>
        /// This method synchronously creates embeddings for multimodal content and returns the results immediately in the response.<br/>
        /// Use this method to embed a query for retrieving matching content. With Marengo 3.5, audio and video can be up to 30 seconds. With Marengo 3.0, they can be up to 10 minutes. For longer content, use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task) method of the `/embed-v2/tasks` endpoint instead.<br/>
        /// The content this method accepts depends on the model. With Marengo 3.5, this method accepts only the `multi_input` input type; provide text, images, audio, video, or documents as media sources. With Marengo 3.0, use the individual input types. For the formats, resolutions, file sizes, and duration limits each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This method is rate-limited. With Marengo 3.5, the platform counts input tokens for each type of content. A request can exceed a limit before you see an error. For details, see [Input token limits for embedding](/v1.3/docs/get-started/rate-limits#input-token-limits-for-embedding).<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `multi_input`: Text and up to 10 media sources, combined into a single embedding. To reference a specific media source from your text, use a placeholder in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Marengo 3.5 accepts images, video, audio, and documents as media sources. Marengo 3.0 accepts images.<br/>
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
        /// - `false`: The platform returns a `400` error.<br/>
        /// - `true`: Truncate your text to fit the limit, and set the [`usage.truncated`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#response.body.usage.truncated) field to `true` in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="embeddingUncertainty">
        /// Set this parameter to `true` to include a per-dimension uncertainty vector in the [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#response.body.data.embedding-uncertainty) field of the response. The vector has the same length as the `embedding` array. A higher value indicates lower confidence in that dimension. Requires Marengo 3.5.<br/>
        /// **Requirements**:<br/>
        /// - Set this parameter to `true` only for a text-only or media-only request. If you combine text with media sources, the platform returns a `400` error.<br/>
        /// - The platform returns a `400` error if your request includes a document, whether PDF, plain text, or Markdown.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="embeddingDimension">
        /// The number of dimensions for each embedding in the response, including the [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#response.body.data.embedding-uncertainty) vector.<br/>
        /// Marengo 3.5 produces Matryoshka embeddings: a shorter embedding consists of the first values of the full-length embedding. A 256-dimension embedding, for example, is the first 256 values of a 512-dimension embedding of the same content. Shorter embeddings reduce index size and speed up similarity search; longer embeddings produce higher retrieval quality.<br/>
        /// **Requirements**:<br/>
        /// - Requires Marengo 3.5. Setting this parameter with `model_name: marengo3.0` returns a `400` error.<br/>
        /// - Applies to the entire request: you cannot set it for a single input type or embedding.<br/>
        /// - Use the same value across an index.<br/>
        /// **Default**: 512
        /// </param>
        /// <param name="text">
        /// This field is required if the `input_type` parameter is `text`.
        /// </param>
        /// <param name="image">
        /// This field is required if the `input_type` parameter is `image`. Requires Marengo 3.0. The decoded file can be up to 32 MB.
        /// </param>
        /// <param name="textImage">
        /// This field is required if the `input_type` parameter is `text_image`. Requires Marengo 3.0. The decoded file can be up to 32 MB.
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`. Requires Marengo 3.0. The decoded file can be up to 36 MB.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`. Requires Marengo 3.0. The decoded file can be up to 36 MB.
        /// </param>
        /// <param name="multiInput">
        /// This field is required if the `input_type` parameter is `multi_input`. It combines text and up to 10 media sources into a single embedding. Provide the `input_text` field, the `media_sources` field, or both.<br/>
        /// Marengo 3.5 accepts images, video, audio, and documents as media sources. Marengo 3.0 accepts images.<br/>
        /// Include text in the `input_text` field when you combine media sources of different types. For example, if you combine an image and a video without text, the platform returns a `400` error. Media sources of the same type do not require text. If any source has no content to embed, the platform returns a `400` error.<br/>
        /// **Document sources**<br/>
        /// The platform embeds a plain text or Markdown document as text. Combining content into a single embedding requires at least one image, video, or audio source; if the content is all text, the platform returns a `400` error. A plain text or Markdown document combined with `input_text`, and two plain text documents, are both all-text content. Send a single text document as your only source, use `input_text` on its own, or add an image, video, or audio source.<br/>
        /// A PDF document must be your only source. You cannot combine it with any other media source, including another document, or with `input_text`; the platform returns a `400` error if you do. To combine document content with an image, video, or audio source, send a plain text or Markdown document instead of a PDF file.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EmbeddingSuccessResponse> CreateAsync(
            global::TwelveLabs.CreateEmbeddingsRequestInputType inputType,
            global::TwelveLabs.CreateEmbeddingsRequestModelName modelName = global::TwelveLabs.CreateEmbeddingsRequestModelName.Marengo30,
            bool? autoTruncate = default,
            bool? embeddingUncertainty = default,
            global::TwelveLabs.CreateEmbeddingsRequestEmbeddingDimension? embeddingDimension = default,
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