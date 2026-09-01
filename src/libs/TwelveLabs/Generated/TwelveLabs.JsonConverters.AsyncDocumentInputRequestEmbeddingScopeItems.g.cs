#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class AsyncDocumentInputRequestEmbeddingScopeItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems Read(
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
                        return global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItemsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItemsExtensions.ToValueString(value));
        }
    }
}
