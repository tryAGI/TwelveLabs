#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class TemporalSegmentationDiscriminatorStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy Read(
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
                        return global::TwelveLabs.TemporalSegmentationDiscriminatorStrategyExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::TwelveLabs.TemporalSegmentationDiscriminatorStrategyExtensions.ToValueString(value));
        }
    }
}
