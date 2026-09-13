
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod), TypeInfoPropertyName = "AssetsPostRequestBodyContentMultipartFormDataSchemaMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetMethod), TypeInfoPropertyName = "AssetMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetStatus), TypeInfoPropertyName = "AssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UserMetadataValue), TypeInfoPropertyName = "UserMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UserMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceType), TypeInfoPropertyName = "AssetSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceDetailsProvider), TypeInfoPropertyName = "AssetSourceDetailsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.Asset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailMethod), TypeInfoPropertyName = "AssetDetailMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailStatus), TypeInfoPropertyName = "AssetDetailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHlsStatus), TypeInfoPropertyName = "AssetHlsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHLS))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnailStatus), TypeInfoPropertyName = "AssetThumbnailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TechnicalMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AudioStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveAssetRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems), TypeInfoPropertyName = "AssetsGetParametersAssetTypesSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AssetDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListAssetsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteAssetRequestConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateAssetUserMetadataRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateAssetUserMetadataRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ReplaceAssetUserMetadataRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ReplaceAssetUserMetadataRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteAssetUserMetadataRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteAssetUserMetadataRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems), TypeInfoPropertyName = "AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetTranscriptionStatus), TypeInfoPropertyName = "AssetTranscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetTranscriptionEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetTranscriptionUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetTranscriptionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetTranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveAssetTranscriptionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveAssetTranscriptionRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateUserMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ReplaceUserMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod?), TypeInfoPropertyName = "NullableAssetsPostRequestBodyContentMultipartFormDataSchemaMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetMethod?), TypeInfoPropertyName = "NullableAssetMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetStatus?), TypeInfoPropertyName = "NullableAssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UserMetadataValue?), TypeInfoPropertyName = "NullableUserMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceType?), TypeInfoPropertyName = "NullableAssetSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceDetailsProvider?), TypeInfoPropertyName = "NullableAssetSourceDetailsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailMethod?), TypeInfoPropertyName = "NullableAssetDetailMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailStatus?), TypeInfoPropertyName = "NullableAssetDetailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHlsStatus?), TypeInfoPropertyName = "NullableAssetHlsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnailStatus?), TypeInfoPropertyName = "NullableAssetThumbnailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems?), TypeInfoPropertyName = "NullableAssetsGetParametersAssetTypesSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems?), TypeInfoPropertyName = "NullableAssetsAssetIdTranscriptionGetParametersIncludeSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetTranscriptionStatus?), TypeInfoPropertyName = "NullableAssetTranscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AudioStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetTranscriptionEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetTranscriptionUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>))]
    internal sealed partial class AssetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AssetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AssetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod)

                    || typeToConvert == typeof(global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetMethod)

                    || typeToConvert == typeof(global::TwelveLabs.AssetMethod?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetStatus)

                    || typeToConvert == typeof(global::TwelveLabs.AssetStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetSourceType)

                    || typeToConvert == typeof(global::TwelveLabs.AssetSourceType?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetSourceDetailsProvider)

                    || typeToConvert == typeof(global::TwelveLabs.AssetSourceDetailsProvider?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetDetailMethod)

                    || typeToConvert == typeof(global::TwelveLabs.AssetDetailMethod?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetDetailStatus)

                    || typeToConvert == typeof(global::TwelveLabs.AssetDetailStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetHlsStatus)

                    || typeToConvert == typeof(global::TwelveLabs.AssetHlsStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetThumbnailStatus)

                    || typeToConvert == typeof(global::TwelveLabs.AssetThumbnailStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AssetTranscriptionStatus)

                    || typeToConvert == typeof(global::TwelveLabs.AssetTranscriptionStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod))
                {
                    return new global::TwelveLabs.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetMethod))
                {
                    return new global::TwelveLabs.JsonConverters.AssetMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetMethod?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetStatus))
                {
                    return new global::TwelveLabs.JsonConverters.AssetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetSourceType))
                {
                    return new global::TwelveLabs.JsonConverters.AssetSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetSourceType?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetSourceDetailsProvider))
                {
                    return new global::TwelveLabs.JsonConverters.AssetSourceDetailsProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetSourceDetailsProvider?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetSourceDetailsProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetDetailMethod))
                {
                    return new global::TwelveLabs.JsonConverters.AssetDetailMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetDetailMethod?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetDetailMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetDetailStatus))
                {
                    return new global::TwelveLabs.JsonConverters.AssetDetailStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetDetailStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetDetailStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetHlsStatus))
                {
                    return new global::TwelveLabs.JsonConverters.AssetHlsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetHlsStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetHlsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetThumbnailStatus))
                {
                    return new global::TwelveLabs.JsonConverters.AssetThumbnailStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetThumbnailStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetThumbnailStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.AssetsGetParametersAssetTypesSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetsGetParametersAssetTypesSchemaItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetTranscriptionStatus))
                {
                    return new global::TwelveLabs.JsonConverters.AssetTranscriptionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AssetTranscriptionStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.AssetTranscriptionStatusNullableJsonConverter();
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
                    0 => new AssetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}