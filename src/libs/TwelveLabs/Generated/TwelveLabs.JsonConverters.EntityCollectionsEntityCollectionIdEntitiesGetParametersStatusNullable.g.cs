#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus?>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus? Read(
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
                        return global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
