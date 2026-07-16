#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class SearchKnowledgeStoreHitJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.SearchKnowledgeStoreHit>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.SearchKnowledgeStoreHit Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.SearchKnowledgeStoreHitDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::TwelveLabs.SearchKnowledgeStoreHitVariant1? video = default;
            if (discriminator?.AssetType == global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.SearchKnowledgeStoreHitVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::TwelveLabs.SearchKnowledgeStoreHitVariant2? image = default;
            if (discriminator?.AssetType == global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.SearchKnowledgeStoreHitVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::TwelveLabs.SearchKnowledgeStoreHit(
                discriminator?.AssetType,
                video,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.SearchKnowledgeStoreHit value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.SearchKnowledgeStoreHitVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.SearchKnowledgeStoreHitVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
        }
    }
}