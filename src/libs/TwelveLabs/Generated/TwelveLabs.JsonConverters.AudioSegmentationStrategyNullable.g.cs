#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class AudioSegmentationStrategyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.AudioSegmentationStrategy?>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.AudioSegmentationStrategy? Read(
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
                        return global::TwelveLabs.AudioSegmentationStrategyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.AudioSegmentationStrategy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.AudioSegmentationStrategy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.AudioSegmentationStrategy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::TwelveLabs.AudioSegmentationStrategyExtensions.ToValueString(value.Value));
            }
        }
    }
}
