
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreMetadataValue), TypeInfoPropertyName = "KnowledgeStoreMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemAssetType), TypeInfoPropertyName = "KnowledgeStoreItemAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemStatus), TypeInfoPropertyName = "KnowledgeStoreItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoMetadataAssetType), TypeInfoPropertyName = "VideoMetadataAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageMetadataAssetType), TypeInfoPropertyName = "ImageMetadataAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadata), TypeInfoPropertyName = "KnowledgeStoreItemSystemMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType), TypeInfoPropertyName = "KnowledgeStoreItemSystemMetadataDiscriminatorAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateKnowledgeStoreItemRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy), TypeInfoPropertyName = "KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems), TypeInfoPropertyName = "KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemsListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListKnowledgeStoreItemsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveKnowledgeStoreItemRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteKnowledgeStoreItemRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreMetadataValue?), TypeInfoPropertyName = "NullableKnowledgeStoreMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemAssetType?), TypeInfoPropertyName = "NullableKnowledgeStoreItemAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemStatus?), TypeInfoPropertyName = "NullableKnowledgeStoreItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoMetadataAssetType?), TypeInfoPropertyName = "NullableVideoMetadataAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageMetadataAssetType?), TypeInfoPropertyName = "NullableImageMetadataAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadata?), TypeInfoPropertyName = "NullableKnowledgeStoreItemSystemMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType?), TypeInfoPropertyName = "NullableKnowledgeStoreItemSystemMetadataDiscriminatorAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy?), TypeInfoPropertyName = "NullableKnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems?), TypeInfoPropertyName = "NullableKnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>))]
    internal sealed partial class KnowledgeStoreItemsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KnowledgeStoreItemsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeStoreItemsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private KnowledgeStoreItemsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreMetadataValueJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemStatus)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoMetadataAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.VideoMetadataAssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.ImageMetadataAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.ImageMetadataAssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemStatus))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoMetadataAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoMetadataAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImageMetadataAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImageMetadataAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new KnowledgeStoreItemsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}