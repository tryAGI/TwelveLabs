
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The number of dimensions for each embedding that the task produces, including the [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.embedding-uncertainty) vector.<br/>
    /// Marengo 3.5 produces Matryoshka embeddings: a shorter embedding consists of the first values of the full-length embedding. A 256-dimension embedding, for example, is the first 256 values of a 512-dimension embedding of the same content. Shorter embeddings reduce index size and speed up similarity search; longer embeddings produce higher retrieval quality.<br/>
    /// **Requirements**:<br/>
    /// - Requires Marengo 3.5. Setting this parameter with `model_name: marengo3.0` returns a `400` error.<br/>
    /// - Applies to the entire task: you cannot set it for a single input type or embedding.<br/>
    /// - Set it once, when you create the task. To use a different value, create a new task.<br/>
    /// - Use the same value across an index.<br/>
    /// **Default**: 512
    /// </summary>
    public enum CreateAsyncEmbeddingRequestEmbeddingDimension
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
    public static class CreateAsyncEmbeddingRequestEmbeddingDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAsyncEmbeddingRequestEmbeddingDimension value)
        {
            return value switch
            {
                CreateAsyncEmbeddingRequestEmbeddingDimension.x128 => "128",
                CreateAsyncEmbeddingRequestEmbeddingDimension.x256 => "256",
                CreateAsyncEmbeddingRequestEmbeddingDimension.x512 => "512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAsyncEmbeddingRequestEmbeddingDimension? ToEnum(string value)
        {
            return value switch
            {
                "128" => CreateAsyncEmbeddingRequestEmbeddingDimension.x128,
                "256" => CreateAsyncEmbeddingRequestEmbeddingDimension.x256,
                "512" => CreateAsyncEmbeddingRequestEmbeddingDimension.x512,
                _ => null,
            };
        }
    }
}