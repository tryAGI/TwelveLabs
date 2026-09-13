
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus), TypeInfoPropertyName = "EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy), TypeInfoPropertyName = "EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityStatus), TypeInfoPropertyName = "EntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.Entity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntitiesListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListEntitiesInCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEntityRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItemsMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BulkCreateEntityResponseEntitiesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BulkCreateEntityResponseErrorsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BulkCreateEntityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEntitiesBulkRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveEntityRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesEntityIdPatchRequestBodyContentApplicationJsonSchemaMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateEntityRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteEntityRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AddEntityAssetsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RemoveEntityAssetsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntitiesListByAssetResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListEntitiesByAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateBulkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteAssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus?), TypeInfoPropertyName = "NullableEntityCollectionsEntityCollectionIdEntitiesGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy?), TypeInfoPropertyName = "NullableEntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityStatus?), TypeInfoPropertyName = "NullableEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>))]
    internal sealed partial class EntityCollectionsEntitiesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EntityCollectionsEntitiesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EntityCollectionsEntitiesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EntityCollectionsEntitiesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus)

                    || typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy)

                    || typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy?)

                    || typeToConvert == typeof(global::TwelveLabs.EntityStatus)

                    || typeToConvert == typeof(global::TwelveLabs.EntityStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus))
                {
                    return new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy))
                {
                    return new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy?))
                {
                    return new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityStatus))
                {
                    return new global::TwelveLabs.JsonConverters.EntityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.EntityStatusNullableJsonConverter();
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
                    0 => new EntityCollectionsEntitiesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}