#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems Read(
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
                        return global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsExtensions.ToValueString(value));
        }
    }
}
