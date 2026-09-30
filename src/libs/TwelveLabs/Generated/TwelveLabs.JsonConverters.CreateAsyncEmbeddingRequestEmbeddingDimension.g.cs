#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAsyncEmbeddingRequestEmbeddingDimensionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimensionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimensionExtensions.ToValueString(value));
        }
    }
}
