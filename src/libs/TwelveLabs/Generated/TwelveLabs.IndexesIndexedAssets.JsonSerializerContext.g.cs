
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UserMetadataValue), TypeInfoPropertyName = "UserMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UserMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexedAssetsCreateResponse202))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexedAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexedAssetRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexedAssetRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems), TypeInfoPropertyName = "IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedStatus), TypeInfoPropertyName = "IndexedAssetDetailedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HlsObjectStatus), TypeInfoPropertyName = "HlsObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HLSObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedEmbeddingVideoEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TranscriptionDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.TranscriptionDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveIndexedAssetInformationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveIndexedAssetInformationRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems), TypeInfoPropertyName = "IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersFps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersHeight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema), TypeInfoPropertyName = "IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetStatus), TypeInfoPropertyName = "IndexedAssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexedAssetsListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListIndexedAssetsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteIndexedAssetInformationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PartialUpdateIndexedAssetInformationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetSummaryIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexedAssetsListByAssetResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAssetSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListIndexedAssetsByAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UserMetadataValue?), TypeInfoPropertyName = "NullableUserMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems?), TypeInfoPropertyName = "NullableIndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedStatus?), TypeInfoPropertyName = "NullableIndexedAssetDetailedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HlsObjectStatus?), TypeInfoPropertyName = "NullableHlsObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems?), TypeInfoPropertyName = "NullableIndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema?), TypeInfoPropertyName = "NullableIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetStatus?), TypeInfoPropertyName = "NullableIndexedAssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.TranscriptionDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexedAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexedAssetSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>))]
    internal sealed partial class IndexesIndexedAssetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IndexesIndexedAssetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static IndexesIndexedAssetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private IndexesIndexedAssetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::TwelveLabs.JsonConverters.UserMetadataValueJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaJsonConverter());
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
                    typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.IndexedAssetDetailedStatus)

                    || typeToConvert == typeof(global::TwelveLabs.IndexedAssetDetailedStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.HlsObjectStatus)

                    || typeToConvert == typeof(global::TwelveLabs.HlsObjectStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.IndexedAssetStatus)

                    || typeToConvert == typeof(global::TwelveLabs.IndexedAssetStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexedAssetDetailedStatus))
                {
                    return new global::TwelveLabs.JsonConverters.IndexedAssetDetailedStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexedAssetDetailedStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.IndexedAssetDetailedStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.HlsObjectStatus))
                {
                    return new global::TwelveLabs.JsonConverters.HlsObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.HlsObjectStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.HlsObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexedAssetStatus))
                {
                    return new global::TwelveLabs.JsonConverters.IndexedAssetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexedAssetStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.IndexedAssetStatusNullableJsonConverter();
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
                    0 => new IndexesIndexedAssetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}