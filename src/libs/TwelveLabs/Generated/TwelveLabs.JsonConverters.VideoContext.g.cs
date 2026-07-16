#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class VideoContextJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.VideoContext>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.VideoContext Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContextDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContextDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.VideoContextDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::TwelveLabs.VideoContextVariant1? url = default;
            if (discriminator?.Type == global::TwelveLabs.VideoContextDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContextVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContextVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.VideoContextVariant1)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::TwelveLabs.VideoContextVariant2? assetId = default;
            if (discriminator?.Type == global::TwelveLabs.VideoContextDiscriminatorType.AssetId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContextVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContextVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.VideoContextVariant2)}");
                assetId = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::TwelveLabs.VideoContextVariant3? base64String = default;
            if (discriminator?.Type == global::TwelveLabs.VideoContextDiscriminatorType.Base64String)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContextVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContextVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.VideoContextVariant3)}");
                base64String = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::TwelveLabs.VideoContext(
                discriminator?.Type,
                url,

                assetId,

                base64String
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.VideoContext value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContextVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContextVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContextVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url!, typeInfo);
            }
            else if (value.IsAssetId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContextVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContextVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContextVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssetId!, typeInfo);
            }
            else if (value.IsBase64String)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContextVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContextVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContextVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64String!, typeInfo);
            }
        }
    }
}