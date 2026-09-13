
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SmeMediaSourceMediaType), TypeInfoPropertyName = "SmeMediaSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SMEMediaSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncResponseFormatType), TypeInfoPropertyName = "AsyncResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldType), TypeInfoPropertyName = "SegmentFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldFormat), TypeInfoPropertyName = "SegmentFieldFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldItemsType), TypeInfoPropertyName = "SegmentFieldItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SegmentField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat), TypeInfoPropertyName = "AsyncResponseFormatSegmentTimeFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SegmentDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResultUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskWebhookInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeBatchRequestModelName), TypeInfoPropertyName = "CreateAnalyzeBatchRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode), TypeInfoPropertyName = "CreateAnalyzeBatchRequestAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchDefaults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchVideoContextType), TypeInfoPropertyName = "BatchVideoContextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchVideoContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.BatchItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchStatus), TypeInfoPropertyName = "BatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreatedBatchItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.CreatedBatchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems), TypeInfoPropertyName = "AnalyzeBatchesGetParametersAnalysisModeSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode), TypeInfoPropertyName = "AnalyzeBatchStatusResponseAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeBatchStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeAsyncBatchesListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchStatusResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchItemStatus), TypeInfoPropertyName = "BatchItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchItemError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.BatchStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SmeMediaSourceMediaType?), TypeInfoPropertyName = "NullableSmeMediaSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.FinishReason?), TypeInfoPropertyName = "NullableFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncResponseFormatType?), TypeInfoPropertyName = "NullableAsyncResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldType?), TypeInfoPropertyName = "NullableSegmentFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldFormat?), TypeInfoPropertyName = "NullableSegmentFieldFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldItemsType?), TypeInfoPropertyName = "NullableSegmentFieldItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat?), TypeInfoPropertyName = "NullableAsyncResponseFormatSegmentTimeFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeBatchRequestModelName?), TypeInfoPropertyName = "NullableCreateAnalyzeBatchRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode?), TypeInfoPropertyName = "NullableCreateAnalyzeBatchRequestAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchVideoContextType?), TypeInfoPropertyName = "NullableBatchVideoContextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchStatus?), TypeInfoPropertyName = "NullableBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems?), TypeInfoPropertyName = "NullableAnalyzeBatchesGetParametersAnalysisModeSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode?), TypeInfoPropertyName = "NullableAnalyzeBatchStatusResponseAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchItemStatus?), TypeInfoPropertyName = "NullableBatchItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SMEMediaSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SegmentField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SegmentDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskWebhookInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BatchItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.CreatedBatchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchStatusResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BatchStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>))]
    internal sealed partial class AnalyzeAsyncBatchesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalyzeAsyncBatchesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnalyzeAsyncBatchesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnalyzeAsyncBatchesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::TwelveLabs.SmeMediaSourceMediaType)

                    || typeToConvert == typeof(global::TwelveLabs.SmeMediaSourceMediaType?)

                    || typeToConvert == typeof(global::TwelveLabs.FinishReason)

                    || typeToConvert == typeof(global::TwelveLabs.FinishReason?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncResponseFormatType)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncResponseFormatType?)

                    || typeToConvert == typeof(global::TwelveLabs.SegmentFieldType)

                    || typeToConvert == typeof(global::TwelveLabs.SegmentFieldType?)

                    || typeToConvert == typeof(global::TwelveLabs.SegmentFieldFormat)

                    || typeToConvert == typeof(global::TwelveLabs.SegmentFieldFormat?)

                    || typeToConvert == typeof(global::TwelveLabs.SegmentFieldItemsType)

                    || typeToConvert == typeof(global::TwelveLabs.SegmentFieldItemsType?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat?)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAnalyzeBatchRequestModelName)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAnalyzeBatchRequestModelName?)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode?)

                    || typeToConvert == typeof(global::TwelveLabs.BatchVideoContextType)

                    || typeToConvert == typeof(global::TwelveLabs.BatchVideoContextType?)

                    || typeToConvert == typeof(global::TwelveLabs.BatchStatus)

                    || typeToConvert == typeof(global::TwelveLabs.BatchStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode?)

                    || typeToConvert == typeof(global::TwelveLabs.BatchItemStatus)

                    || typeToConvert == typeof(global::TwelveLabs.BatchItemStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.SmeMediaSourceMediaType))
                {
                    return new global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SmeMediaSourceMediaType?))
                {
                    return new global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.FinishReason))
                {
                    return new global::TwelveLabs.JsonConverters.FinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.FinishReason?))
                {
                    return new global::TwelveLabs.JsonConverters.FinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncResponseFormatType))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncResponseFormatType?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SegmentFieldType))
                {
                    return new global::TwelveLabs.JsonConverters.SegmentFieldTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SegmentFieldType?))
                {
                    return new global::TwelveLabs.JsonConverters.SegmentFieldTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SegmentFieldFormat))
                {
                    return new global::TwelveLabs.JsonConverters.SegmentFieldFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SegmentFieldFormat?))
                {
                    return new global::TwelveLabs.JsonConverters.SegmentFieldFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SegmentFieldItemsType))
                {
                    return new global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SegmentFieldItemsType?))
                {
                    return new global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncResponseFormatSegmentTimeFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncResponseFormatSegmentTimeFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAnalyzeBatchRequestModelName))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAnalyzeBatchRequestModelName?))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestAnalysisModeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode?))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestAnalysisModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.BatchVideoContextType))
                {
                    return new global::TwelveLabs.JsonConverters.BatchVideoContextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.BatchVideoContextType?))
                {
                    return new global::TwelveLabs.JsonConverters.BatchVideoContextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.BatchStatus))
                {
                    return new global::TwelveLabs.JsonConverters.BatchStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.BatchStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.BatchStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeBatchesGetParametersAnalysisModeSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeBatchesGetParametersAnalysisModeSchemaItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeBatchStatusResponseAnalysisModeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode?))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeBatchStatusResponseAnalysisModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.BatchItemStatus))
                {
                    return new global::TwelveLabs.JsonConverters.BatchItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.BatchItemStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.BatchItemStatusNullableJsonConverter();
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
                    0 => new AnalyzeAsyncBatchesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}