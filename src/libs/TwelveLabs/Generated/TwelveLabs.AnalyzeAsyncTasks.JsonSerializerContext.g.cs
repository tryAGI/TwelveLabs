
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContext), TypeInfoPropertyName = "VideoContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant1Type), TypeInfoPropertyName = "VideoContextVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant2Type), TypeInfoPropertyName = "VideoContextVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant3Type), TypeInfoPropertyName = "VideoContextVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextDiscriminatorType), TypeInfoPropertyName = "VideoContextDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SmeMediaSourceMediaType), TypeInfoPropertyName = "SmeMediaSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SMEMediaSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzePromptV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestModelName), TypeInfoPropertyName = "CreateAsyncAnalyzeRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode), TypeInfoPropertyName = "CreateAsyncAnalyzeRequestAnalysisMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncAnalyzeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskStatus), TypeInfoPropertyName = "AnalyzeTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode), TypeInfoPropertyName = "AnalyzeTasksGetParametersAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseVideoSourceType), TypeInfoPropertyName = "AnalyzeTaskResponseVideoSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseVideoSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode), TypeInfoPropertyName = "AnalyzeTaskResponseRequestParamsAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType), TypeInfoPropertyName = "AnalyzeTaskResponseRequestParamsResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsFieldsItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsFieldsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsMediaSourcesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsFieldsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsMediaSourcesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResultUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskWebhookInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeAsyncTasksListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListAsyncAnalysisTasksRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContext?), TypeInfoPropertyName = "NullableVideoContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant1Type?), TypeInfoPropertyName = "NullableVideoContextVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant2Type?), TypeInfoPropertyName = "NullableVideoContextVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant3Type?), TypeInfoPropertyName = "NullableVideoContextVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextDiscriminatorType?), TypeInfoPropertyName = "NullableVideoContextDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SmeMediaSourceMediaType?), TypeInfoPropertyName = "NullableSmeMediaSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.FinishReason?), TypeInfoPropertyName = "NullableFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestModelName?), TypeInfoPropertyName = "NullableCreateAsyncAnalyzeRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode?), TypeInfoPropertyName = "NullableCreateAsyncAnalyzeRequestAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncResponseFormatType?), TypeInfoPropertyName = "NullableAsyncResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldType?), TypeInfoPropertyName = "NullableSegmentFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldFormat?), TypeInfoPropertyName = "NullableSegmentFieldFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldItemsType?), TypeInfoPropertyName = "NullableSegmentFieldItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat?), TypeInfoPropertyName = "NullableAsyncResponseFormatSegmentTimeFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskStatus?), TypeInfoPropertyName = "NullableAnalyzeTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode?), TypeInfoPropertyName = "NullableAnalyzeTasksGetParametersAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseVideoSourceType?), TypeInfoPropertyName = "NullableAnalyzeTaskResponseVideoSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode?), TypeInfoPropertyName = "NullableAnalyzeTaskResponseRequestParamsAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType?), TypeInfoPropertyName = "NullableAnalyzeTaskResponseRequestParamsResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SMEMediaSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SegmentField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SegmentDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsFieldsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsMediaSourcesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskWebhookInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponse>))]
    internal sealed partial class AnalyzeAsyncTasksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalyzeAsyncTasksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnalyzeAsyncTasksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnalyzeAsyncTasksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextJsonConverter());
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
                    typeToConvert == typeof(global::TwelveLabs.VideoContextVariant1Type)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant1Type?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant2Type)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant2Type?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant3Type)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant3Type?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextDiscriminatorType)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextDiscriminatorType?)

                    || typeToConvert == typeof(global::TwelveLabs.SmeMediaSourceMediaType)

                    || typeToConvert == typeof(global::TwelveLabs.SmeMediaSourceMediaType?)

                    || typeToConvert == typeof(global::TwelveLabs.FinishReason)

                    || typeToConvert == typeof(global::TwelveLabs.FinishReason?)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestModelName)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestModelName?)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode?)

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

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskStatus)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode?)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseVideoSourceType)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseVideoSourceType?)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode?)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.VideoContextVariant1Type))
                {
                    return new global::TwelveLabs.JsonConverters.VideoContextVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoContextVariant1Type?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoContextVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoContextVariant2Type))
                {
                    return new global::TwelveLabs.JsonConverters.VideoContextVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoContextVariant2Type?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoContextVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoContextVariant3Type))
                {
                    return new global::TwelveLabs.JsonConverters.VideoContextVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoContextVariant3Type?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoContextVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoContextDiscriminatorType))
                {
                    return new global::TwelveLabs.JsonConverters.VideoContextDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoContextDiscriminatorType?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoContextDiscriminatorTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestModelName))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestModelName?))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode?))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskStatus))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeTaskStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeTaskStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeTasksGetParametersAnalysisModeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode?))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeTasksGetParametersAnalysisModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseVideoSourceType))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseVideoSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseVideoSourceType?))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseVideoSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsAnalysisModeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode?))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsAnalysisModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType?))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsResponseFormatTypeNullableJsonConverter();
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
                    0 => new AnalyzeAsyncTasksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}