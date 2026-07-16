#nullable enable

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseStreamFuncCallArgsDoneEventTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType Read(
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
                        return global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventTypeExtensions.ToValueString(value));
        }
    }
}
