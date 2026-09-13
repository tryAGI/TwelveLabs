
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequestType), TypeInfoPropertyName = "CreateAssetUploadRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PresignedURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.PresignedURLChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateMultipartUploadRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateMultipartUploadRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateMultipartUploadRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MultipartUploadStatusType), TypeInfoPropertyName = "MultipartUploadStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ChunkInfoStatus), TypeInfoPropertyName = "ChunkInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ChunkInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.GetUploadStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ChunkInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.GetUploadStatusRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.GetUploadStatusRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.GetUploadStatusRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IncompleteUploadSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListIncompleteUploadsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IncompleteUploadSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListIncompleteUploadsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListIncompleteUploadsRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListIncompleteUploadsRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CompletedChunkProofType), TypeInfoPropertyName = "CompletedChunkProofType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CompletedChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ReportChunkBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.CompletedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ReportChunkBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ReportChunkBatchRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ReportChunkBatchRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RequestAdditionalPresignedURLsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RequestAdditionalPresignedURLsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RequestAdditionalPresignedUrlsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RequestAdditionalPresignedUrlsRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RequestAdditionalPresignedUrlsRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UserMetadataValue?), TypeInfoPropertyName = "NullableUserMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequestType?), TypeInfoPropertyName = "NullableCreateAssetUploadRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MultipartUploadStatusType?), TypeInfoPropertyName = "NullableMultipartUploadStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ChunkInfoStatus?), TypeInfoPropertyName = "NullableChunkInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CompletedChunkProofType?), TypeInfoPropertyName = "NullableCompletedChunkProofType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.PresignedURLChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ChunkInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IncompleteUploadSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.CompletedChunk>))]
    internal sealed partial class MultipartUploadSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MultipartUploadSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MultipartUploadSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MultipartUploadSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::TwelveLabs.CreateAssetUploadRequestType)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAssetUploadRequestType?)

                    || typeToConvert == typeof(global::TwelveLabs.MultipartUploadStatusType)

                    || typeToConvert == typeof(global::TwelveLabs.MultipartUploadStatusType?)

                    || typeToConvert == typeof(global::TwelveLabs.ChunkInfoStatus)

                    || typeToConvert == typeof(global::TwelveLabs.ChunkInfoStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.CompletedChunkProofType)

                    || typeToConvert == typeof(global::TwelveLabs.CompletedChunkProofType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.CreateAssetUploadRequestType))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAssetUploadRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAssetUploadRequestType?))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAssetUploadRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.MultipartUploadStatusType))
                {
                    return new global::TwelveLabs.JsonConverters.MultipartUploadStatusTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.MultipartUploadStatusType?))
                {
                    return new global::TwelveLabs.JsonConverters.MultipartUploadStatusTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ChunkInfoStatus))
                {
                    return new global::TwelveLabs.JsonConverters.ChunkInfoStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ChunkInfoStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.ChunkInfoStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CompletedChunkProofType))
                {
                    return new global::TwelveLabs.JsonConverters.CompletedChunkProofTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CompletedChunkProofType?))
                {
                    return new global::TwelveLabs.JsonConverters.CompletedChunkProofTypeNullableJsonConverter();
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
                    0 => new MultipartUploadSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}