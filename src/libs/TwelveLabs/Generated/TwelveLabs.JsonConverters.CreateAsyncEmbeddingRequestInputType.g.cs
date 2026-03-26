#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAsyncEmbeddingRequestInputTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.CreateAsyncEmbeddingRequestInputType>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.CreateAsyncEmbeddingRequestInputType Read(
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
                        return global::TwelveLabs.CreateAsyncEmbeddingRequestInputTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.CreateAsyncEmbeddingRequestInputType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.CreateAsyncEmbeddingRequestInputType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.CreateAsyncEmbeddingRequestInputType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::TwelveLabs.CreateAsyncEmbeddingRequestInputTypeExtensions.ToValueString(value));
        }
    }
}
