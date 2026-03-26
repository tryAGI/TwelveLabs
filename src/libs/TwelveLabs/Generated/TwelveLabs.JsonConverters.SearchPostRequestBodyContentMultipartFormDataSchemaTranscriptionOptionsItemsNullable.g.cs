#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems?>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems? Read(
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
                        return global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsExtensions.ToValueString(value.Value));
            }
        }
    }
}
