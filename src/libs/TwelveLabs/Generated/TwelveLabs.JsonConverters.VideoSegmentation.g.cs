#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class VideoSegmentationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.VideoSegmentation>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.VideoSegmentation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoSegmentationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoSegmentationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.VideoSegmentationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::TwelveLabs.VideoSegmentationVariant1? dynamic = default;
            if (discriminator?.Strategy == global::TwelveLabs.VideoSegmentationDiscriminatorStrategy.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoSegmentationVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoSegmentationVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.VideoSegmentationVariant1)}");
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::TwelveLabs.VideoSegmentationVariant2? @fixed = default;
            if (discriminator?.Strategy == global::TwelveLabs.VideoSegmentationDiscriminatorStrategy.Fixed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoSegmentationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoSegmentationVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.VideoSegmentationVariant2)}");
                @fixed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::TwelveLabs.VideoSegmentation(
                discriminator?.Strategy,
                dynamic,

                @fixed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.VideoSegmentation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoSegmentationVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoSegmentationVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoSegmentationVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic!, typeInfo);
            }
            else if (value.IsFixed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoSegmentationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoSegmentationVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoSegmentationVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Fixed!, typeInfo);
            }
        }
    }
}