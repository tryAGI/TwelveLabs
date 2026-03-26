#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class AudioInputRequestEmbeddingTypeItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.AudioInputRequestEmbeddingTypeItems Read(
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
                        return global::TwelveLabs.AudioInputRequestEmbeddingTypeItemsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.AudioInputRequestEmbeddingTypeItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.AudioInputRequestEmbeddingTypeItems);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.AudioInputRequestEmbeddingTypeItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::TwelveLabs.AudioInputRequestEmbeddingTypeItemsExtensions.ToValueString(value));
        }
    }
}
