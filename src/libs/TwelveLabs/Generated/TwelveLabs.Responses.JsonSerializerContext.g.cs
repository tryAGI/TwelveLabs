
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseInputItemType), TypeInfoPropertyName = "ResponseInputItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseInputItemRole), TypeInfoPropertyName = "ResponseInputItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseInputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems), TypeInfoPropertyName = "ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseSelectionKind), TypeInfoPropertyName = "ResponseSelectionKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseSelection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextResponseFormatTextType), TypeInfoPropertyName = "TextResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextResponseFormatJsonSchemaType), TypeInfoPropertyName = "TextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextParamFormat), TypeInfoPropertyName = "TextParamFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextParamFormatVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextParamFormatVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextParamFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextParamFormatDiscriminatorType), TypeInfoPropertyName = "TextParamFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseObjectType), TypeInfoPropertyName = "ResponseObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseObjectObject), TypeInfoPropertyName = "ResponseObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStatus), TypeInfoPropertyName = "ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseIncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputItemType), TypeInfoPropertyName = "ResponseOutputItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputItemRole), TypeInfoPropertyName = "ResponseOutputItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputContentPartType), TypeInfoPropertyName = "ResponseOutputContentPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseAnnotationType), TypeInfoPropertyName = "ResponseAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponseAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateResponseRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamResponseEventType), TypeInfoPropertyName = "ResponseStreamResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamOutputItemAddedEventType), TypeInfoPropertyName = "ResponseStreamOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamContentPartAddedEventType), TypeInfoPropertyName = "ResponseStreamContentPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamOutputTextDeltaEventType), TypeInfoPropertyName = "ResponseStreamOutputTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamOutputTextDoneEventType), TypeInfoPropertyName = "ResponseStreamOutputTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamContentPartDoneEventType), TypeInfoPropertyName = "ResponseStreamContentPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamOutputItemDoneEventType), TypeInfoPropertyName = "ResponseStreamOutputItemDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType), TypeInfoPropertyName = "ResponseStreamFuncCallArgsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEvent), TypeInfoPropertyName = "ResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventDiscriminatorType), TypeInfoPropertyName = "ResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseInputItemType?), TypeInfoPropertyName = "NullableResponseInputItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseInputItemRole?), TypeInfoPropertyName = "NullableResponseInputItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems?), TypeInfoPropertyName = "NullableResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseSelectionKind?), TypeInfoPropertyName = "NullableResponseSelectionKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextResponseFormatTextType?), TypeInfoPropertyName = "NullableTextResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableTextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextParamFormat?), TypeInfoPropertyName = "NullableTextParamFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextParamFormatDiscriminatorType?), TypeInfoPropertyName = "NullableTextParamFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseObjectType?), TypeInfoPropertyName = "NullableResponseObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseObjectObject?), TypeInfoPropertyName = "NullableResponseObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStatus?), TypeInfoPropertyName = "NullableResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputItemType?), TypeInfoPropertyName = "NullableResponseOutputItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputItemRole?), TypeInfoPropertyName = "NullableResponseOutputItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputContentPartType?), TypeInfoPropertyName = "NullableResponseOutputContentPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseAnnotationType?), TypeInfoPropertyName = "NullableResponseAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamResponseEventType?), TypeInfoPropertyName = "NullableResponseStreamResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamOutputItemAddedEventType?), TypeInfoPropertyName = "NullableResponseStreamOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamContentPartAddedEventType?), TypeInfoPropertyName = "NullableResponseStreamContentPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamOutputTextDeltaEventType?), TypeInfoPropertyName = "NullableResponseStreamOutputTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamOutputTextDoneEventType?), TypeInfoPropertyName = "NullableResponseStreamOutputTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamContentPartDoneEventType?), TypeInfoPropertyName = "NullableResponseStreamContentPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamOutputItemDoneEventType?), TypeInfoPropertyName = "NullableResponseStreamOutputItemDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType?), TypeInfoPropertyName = "NullableResponseStreamFuncCallArgsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEvent?), TypeInfoPropertyName = "NullableResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponseAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponseOutputContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponseInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponseSelection>))]
    internal sealed partial class ResponsesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ResponsesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ResponsesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TextParamFormatJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamEventJsonConverter());
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
                    typeToConvert == typeof(global::TwelveLabs.ResponseInputItemType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseInputItemType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseInputItemRole)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseInputItemRole?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems)

                    || typeToConvert == typeof(global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseSelectionKind)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseSelectionKind?)

                    || typeToConvert == typeof(global::TwelveLabs.TextResponseFormatTextType)

                    || typeToConvert == typeof(global::TwelveLabs.TextResponseFormatTextType?)

                    || typeToConvert == typeof(global::TwelveLabs.TextResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::TwelveLabs.TextResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::TwelveLabs.TextParamFormatDiscriminatorType)

                    || typeToConvert == typeof(global::TwelveLabs.TextParamFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseObjectType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseObjectType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseObjectObject)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseObjectObject?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStatus)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseOutputItemType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseOutputItemType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseOutputItemRole)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseOutputItemRole?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseOutputContentPartType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseOutputContentPartType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseAnnotationType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseAnnotationType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamResponseEventType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamResponseEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputItemAddedEventType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputItemAddedEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamContentPartAddedEventType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamContentPartAddedEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputTextDeltaEventType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputTextDeltaEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputTextDoneEventType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputTextDoneEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamContentPartDoneEventType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamContentPartDoneEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputItemDoneEventType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputItemDoneEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamEventDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.ResponseInputItemType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseInputItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseInputItemType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseInputItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseInputItemRole))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseInputItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseInputItemRole?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseInputItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems))
                {
                    return new global::TwelveLabs.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseSelectionKind))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseSelectionKindJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseSelectionKind?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseSelectionKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TextResponseFormatTextType))
                {
                    return new global::TwelveLabs.JsonConverters.TextResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TextResponseFormatTextType?))
                {
                    return new global::TwelveLabs.JsonConverters.TextResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TextResponseFormatJsonSchemaType))
                {
                    return new global::TwelveLabs.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TextResponseFormatJsonSchemaType?))
                {
                    return new global::TwelveLabs.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TextParamFormatDiscriminatorType))
                {
                    return new global::TwelveLabs.JsonConverters.TextParamFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TextParamFormatDiscriminatorType?))
                {
                    return new global::TwelveLabs.JsonConverters.TextParamFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseObjectType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseObjectType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseObjectObject))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseObjectObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseObjectObject?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseObjectObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStatus))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseOutputItemType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseOutputItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseOutputItemType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseOutputItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseOutputItemRole))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseOutputItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseOutputItemRole?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseOutputItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseOutputContentPartType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseOutputContentPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseOutputContentPartType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseOutputContentPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseAnnotationType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseAnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseAnnotationType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseAnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamResponseEventType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamResponseEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamResponseEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamResponseEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputItemAddedEventType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamOutputItemAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputItemAddedEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamOutputItemAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamContentPartAddedEventType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamContentPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamContentPartAddedEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamContentPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputTextDeltaEventType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputTextDeltaEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputTextDoneEventType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputTextDoneEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamContentPartDoneEventType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamContentPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamContentPartDoneEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamContentPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputItemDoneEventType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamOutputItemDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamOutputItemDoneEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamOutputItemDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamFuncCallArgsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamFuncCallArgsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamEventDiscriminatorType))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ResponseStreamEventDiscriminatorType?))
                {
                    return new global::TwelveLabs.JsonConverters.ResponseStreamEventDiscriminatorTypeNullableJsonConverter();
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
                    0 => new ResponsesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}