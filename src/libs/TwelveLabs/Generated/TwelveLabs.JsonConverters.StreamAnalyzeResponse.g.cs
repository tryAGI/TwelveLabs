#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class StreamAnalyzeResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.StreamAnalyzeResponse>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.StreamAnalyzeResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.StreamAnalyzeResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.StreamAnalyzeResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.StreamAnalyzeResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::TwelveLabs.StreamAnalyzeResponseVariant1? streamStart = default;
            if (discriminator?.EventType == global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType.StreamStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.StreamAnalyzeResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.StreamAnalyzeResponseVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.StreamAnalyzeResponseVariant1)}");
                streamStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::TwelveLabs.StreamAnalyzeResponseVariant2? textGeneration = default;
            if (discriminator?.EventType == global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType.TextGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.StreamAnalyzeResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.StreamAnalyzeResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.StreamAnalyzeResponseVariant2)}");
                textGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::TwelveLabs.StreamAnalyzeResponseVariant3? streamEnd = default;
            if (discriminator?.EventType == global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType.StreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.StreamAnalyzeResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.StreamAnalyzeResponseVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.StreamAnalyzeResponseVariant3)}");
                streamEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::TwelveLabs.StreamAnalyzeResponse(
                discriminator?.EventType,
                streamStart,

                textGeneration,

                streamEnd
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.StreamAnalyzeResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.StreamAnalyzeResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.StreamAnalyzeResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.StreamAnalyzeResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamStart!, typeInfo);
            }
            else if (value.IsTextGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.StreamAnalyzeResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.StreamAnalyzeResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.StreamAnalyzeResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGeneration!, typeInfo);
            }
            else if (value.IsStreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.StreamAnalyzeResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.StreamAnalyzeResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.StreamAnalyzeResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEnd!, typeInfo);
            }
        }
    }
}