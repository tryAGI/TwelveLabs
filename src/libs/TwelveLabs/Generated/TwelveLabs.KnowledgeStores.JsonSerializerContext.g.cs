
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType), TypeInfoPropertyName = "EnrichmentConfigJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType), TypeInfoPropertyName = "EnrichmentConfigJsonSchemaJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigDescriptionType), TypeInfoPropertyName = "EnrichmentConfigDescriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfig), TypeInfoPropertyName = "EnrichmentConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType), TypeInfoPropertyName = "EnrichmentConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IngestionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreMetadataValue), TypeInfoPropertyName = "KnowledgeStoreMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateKnowledgeStoreRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy), TypeInfoPropertyName = "KnowledgeStoresGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListKnowledgeStoresRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveKnowledgeStoreRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateKnowledgeStoreRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteKnowledgeStoreRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreSearchQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemAssetType), TypeInfoPropertyName = "KnowledgeStoreItemAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetTypeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemAssetType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ItemIdFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSearchModality), TypeInfoPropertyName = "VideoSearchModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy), TypeInfoPropertyName = "SearchKnowledgeStoreRequestGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSearchSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSearchItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageSearchSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageSearchItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHit), TypeInfoPropertyName = "SearchKnowledgeStoreHit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType), TypeInfoPropertyName = "SearchKnowledgeStoreHitVariant1AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType), TypeInfoPropertyName = "SearchKnowledgeStoreHitVariant2AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType), TypeInfoPropertyName = "SearchKnowledgeStoreHitDiscriminatorAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchKnowledgeStoreHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGoneError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType?), TypeInfoPropertyName = "NullableEnrichmentConfigJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType?), TypeInfoPropertyName = "NullableEnrichmentConfigJsonSchemaJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigDescriptionType?), TypeInfoPropertyName = "NullableEnrichmentConfigDescriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfig?), TypeInfoPropertyName = "NullableEnrichmentConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType?), TypeInfoPropertyName = "NullableEnrichmentConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreMetadataValue?), TypeInfoPropertyName = "NullableKnowledgeStoreMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy?), TypeInfoPropertyName = "NullableKnowledgeStoresGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemAssetType?), TypeInfoPropertyName = "NullableKnowledgeStoreItemAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSearchModality?), TypeInfoPropertyName = "NullableVideoSearchModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy?), TypeInfoPropertyName = "NullableSearchKnowledgeStoreRequestGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHit?), TypeInfoPropertyName = "NullableSearchKnowledgeStoreHit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType?), TypeInfoPropertyName = "NullableSearchKnowledgeStoreHitVariant1AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType?), TypeInfoPropertyName = "NullableSearchKnowledgeStoreHitVariant2AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType?), TypeInfoPropertyName = "NullableSearchKnowledgeStoreHitDiscriminatorAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItemAssetType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoSearchModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchKnowledgeStoreHit>))]
    internal sealed partial class KnowledgeStoresSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KnowledgeStoresSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeStoresSourceGenerationContext Default { get; } = new(DefaultOptions);

        private KnowledgeStoresSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreMetadataValueJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitJsonConverter());
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
                    typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType?)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType?)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDescriptionType)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDescriptionType?)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSearchModality)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSearchModality?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType?))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType?))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDescriptionType))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDescriptionType?))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType?))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresGetParametersSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresGetParametersSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoSearchModality))
                {
                    return new global::TwelveLabs.JsonConverters.VideoSearchModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoSearchModality?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoSearchModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeNullableJsonConverter();
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
                    0 => new KnowledgeStoresSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}