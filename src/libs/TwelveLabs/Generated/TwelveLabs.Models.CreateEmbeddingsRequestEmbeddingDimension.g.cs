
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The number of dimensions for each embedding in the response, including the [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#response.body.data.embedding-uncertainty) vector.<br/>
    /// Marengo 3.5 produces Matryoshka embeddings: a shorter embedding consists of the first values of the full-length embedding. A 256-dimension embedding, for example, is the first 256 values of a 512-dimension embedding of the same content. Shorter embeddings reduce index size and speed up similarity search; longer embeddings produce higher retrieval quality.<br/>
    /// **Requirements**:<br/>
    /// - Requires Marengo 3.5. Setting this parameter with `model_name: marengo3.0` returns a `400` error.<br/>
    /// - Applies to the entire request: you cannot set it for a single input type or embedding.<br/>
    /// - Use the same value across an index.<br/>
    /// **Default**: 512
    /// </summary>
    public enum CreateEmbeddingsRequestEmbeddingDimension
    {
        /// <summary>
        ///
        /// </summary>
        x128,
        /// <summary>
        /// a shorter embedding consists of the first values of the full-length embedding. A 256-dimension embedding, for example, is the first 256 values of a 512-dimension embedding of the same content. Shorter embeddings reduce index size and speed up similarity search; longer embeddings produce higher retrieval quality.
        /// </summary>
        x256,
        /// <summary>
        /// a shorter embedding consists of the first values of the full-length embedding. A 256-dimension embedding, for example, is the first 256 values of a 512-dimension embedding of the same content. Shorter embeddings reduce index size and speed up similarity search; longer embeddings produce higher retrieval quality.
        /// </summary>
        x512,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingsRequestEmbeddingDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingsRequestEmbeddingDimension value)
        {
            return value switch
            {
                CreateEmbeddingsRequestEmbeddingDimension.x128 => "128",
                CreateEmbeddingsRequestEmbeddingDimension.x256 => "256",
                CreateEmbeddingsRequestEmbeddingDimension.x512 => "512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingsRequestEmbeddingDimension? ToEnum(string value)
        {
            return value switch
            {
                "128" => CreateEmbeddingsRequestEmbeddingDimension.x128,
                "256" => CreateEmbeddingsRequestEmbeddingDimension.x256,
                "512" => CreateEmbeddingsRequestEmbeddingDimension.x512,
                _ => null,
            };
        }
    }
}