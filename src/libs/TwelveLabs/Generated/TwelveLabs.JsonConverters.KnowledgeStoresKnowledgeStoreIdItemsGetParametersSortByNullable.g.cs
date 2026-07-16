#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy?>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy? Read(
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
                        return global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByExtensions.ToValueString(value.Value));
            }
        }
    }
}
