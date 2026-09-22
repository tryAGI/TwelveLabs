
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.UserMetadataValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType), TypeInfoPropertyName = "SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl), TypeInfoPropertyName = "SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile), TypeInfoPropertyName = "SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems), TypeInfoPropertyName = "SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems), TypeInfoPropertyName = "SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy), TypeInfoPropertyName = "SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator), TypeInfoPropertyName = "SearchPostRequestBodyContentMultipartFormDataSchemaOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchItemClipsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchItemClipsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchResultsPageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnyToVideoSearchRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchRetrieveResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnyToVideoRetrieveSpecificPageRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UserMetadataValue?), TypeInfoPropertyName = "NullableUserMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchItemClipsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>))]
    internal sealed partial class SearchSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SearchSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SearchSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileJsonConverter());
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
                    typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType))
                {
                    return new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems))
                {
                    return new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems))
                {
                    return new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy))
                {
                    return new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator))
                {
                    return new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorNullableJsonConverter();
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
                    0 => new SearchSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}