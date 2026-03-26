#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchPostRequestBodyContentMultipartFormDataSchemaOperatorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator Read(
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
                        return global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorExtensions.ToValueString(value));
        }
    }
}
