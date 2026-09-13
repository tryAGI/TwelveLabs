
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEmbeddingsRequestInputType), TypeInfoPropertyName = "CreateEmbeddingsRequestInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEmbeddingsRequestModelName), TypeInfoPropertyName = "CreateEmbeddingsRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MediaSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextImageInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioSegmentationFixed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioSegmentation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioSegmentationStrategy), TypeInfoPropertyName = "AudioSegmentationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioInputRequestEmbeddingOptionItems), TypeInfoPropertyName = "AudioInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioInputRequestEmbeddingScopeItems), TypeInfoPropertyName = "AudioInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioInputRequestEmbeddingTypeItems), TypeInfoPropertyName = "AudioInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationDiscriminatorMappingDynamicDynamic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationDiscriminatorMappingFixedFixed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentation), TypeInfoPropertyName = "VideoSegmentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant1Strategy), TypeInfoPropertyName = "VideoSegmentationVariant1Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant2Strategy), TypeInfoPropertyName = "VideoSegmentationVariant2Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationDiscriminatorStrategy), TypeInfoPropertyName = "VideoSegmentationDiscriminatorStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoInputRequestEmbeddingOptionItems), TypeInfoPropertyName = "VideoInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoInputRequestEmbeddingScopeItems), TypeInfoPropertyName = "VideoInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoInputRequestEmbeddingTypeItems), TypeInfoPropertyName = "VideoInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MultiInputMediaSourceMediaType), TypeInfoPropertyName = "MultiInputMediaSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MultiInputMediaSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MultiInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.MultiInputMediaSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption), TypeInfoPropertyName = "EmbeddingDataEmbeddingOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope), TypeInfoPropertyName = "EmbeddingDataEmbeddingScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType), TypeInfoPropertyName = "EmbeddingMediaMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems), TypeInfoPropertyName = "EmbeddingAudioMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems), TypeInfoPropertyName = "EmbeddingVideoMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadata), TypeInfoPropertyName = "EmbeddingMediaMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEmbeddingsRequestInputType?), TypeInfoPropertyName = "NullableCreateEmbeddingsRequestInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEmbeddingsRequestModelName?), TypeInfoPropertyName = "NullableCreateEmbeddingsRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioSegmentationStrategy?), TypeInfoPropertyName = "NullableAudioSegmentationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioInputRequestEmbeddingOptionItems?), TypeInfoPropertyName = "NullableAudioInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioInputRequestEmbeddingScopeItems?), TypeInfoPropertyName = "NullableAudioInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioInputRequestEmbeddingTypeItems?), TypeInfoPropertyName = "NullableAudioInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentation?), TypeInfoPropertyName = "NullableVideoSegmentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant1Strategy?), TypeInfoPropertyName = "NullableVideoSegmentationVariant1Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant2Strategy?), TypeInfoPropertyName = "NullableVideoSegmentationVariant2Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationDiscriminatorStrategy?), TypeInfoPropertyName = "NullableVideoSegmentationDiscriminatorStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoInputRequestEmbeddingOptionItems?), TypeInfoPropertyName = "NullableVideoInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoInputRequestEmbeddingScopeItems?), TypeInfoPropertyName = "NullableVideoInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoInputRequestEmbeddingTypeItems?), TypeInfoPropertyName = "NullableVideoInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MultiInputMediaSourceMediaType?), TypeInfoPropertyName = "NullableMultiInputMediaSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption?), TypeInfoPropertyName = "NullableEmbeddingDataEmbeddingOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope?), TypeInfoPropertyName = "NullableEmbeddingDataEmbeddingScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType?), TypeInfoPropertyName = "NullableEmbeddingMediaMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems?), TypeInfoPropertyName = "NullableEmbeddingAudioMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems?), TypeInfoPropertyName = "NullableEmbeddingVideoMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadata?), TypeInfoPropertyName = "NullableEmbeddingMediaMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.MultiInputMediaSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingData>))]
    internal sealed partial class EmbedV2SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbedV2SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EmbedV2SourceGenerationContext Default { get; } = new(DefaultOptions);

        private EmbedV2SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoSegmentationJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataJsonConverter());
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
                    typeToConvert == typeof(global::TwelveLabs.CreateEmbeddingsRequestInputType)

                    || typeToConvert == typeof(global::TwelveLabs.CreateEmbeddingsRequestInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.CreateEmbeddingsRequestModelName)

                    || typeToConvert == typeof(global::TwelveLabs.CreateEmbeddingsRequestModelName?)

                    || typeToConvert == typeof(global::TwelveLabs.AudioSegmentationStrategy)

                    || typeToConvert == typeof(global::TwelveLabs.AudioSegmentationStrategy?)

                    || typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingOptionItems)

                    || typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingOptionItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingScopeItems)

                    || typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingScopeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingTypeItems)

                    || typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingTypeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant1Strategy)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant1Strategy?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant2Strategy)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant2Strategy?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationDiscriminatorStrategy)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationDiscriminatorStrategy?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingOptionItems)

                    || typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingOptionItems?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingScopeItems)

                    || typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingScopeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingTypeItems)

                    || typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingTypeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.MultiInputMediaSourceMediaType)

                    || typeToConvert == typeof(global::TwelveLabs.MultiInputMediaSourceMediaType?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.CreateEmbeddingsRequestInputType))
                {
                    return new global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateEmbeddingsRequestInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateEmbeddingsRequestModelName))
                {
                    return new global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateEmbeddingsRequestModelName?))
                {
                    return new global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AudioSegmentationStrategy))
                {
                    return new global::TwelveLabs.JsonConverters.AudioSegmentationStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AudioSegmentationStrategy?))
                {
                    return new global::TwelveLabs.JsonConverters.AudioSegmentationStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingOptionItems))
                {
                    return new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingOptionItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingOptionItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingOptionItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingScopeItems))
                {
                    return new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingScopeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingScopeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingScopeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingTypeItems))
                {
                    return new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingTypeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AudioInputRequestEmbeddingTypeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingTypeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant1Strategy))
                {
                    return new global::TwelveLabs.JsonConverters.VideoSegmentationVariant1StrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant1Strategy?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoSegmentationVariant1StrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant2Strategy))
                {
                    return new global::TwelveLabs.JsonConverters.VideoSegmentationVariant2StrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant2Strategy?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoSegmentationVariant2StrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoSegmentationDiscriminatorStrategy))
                {
                    return new global::TwelveLabs.JsonConverters.VideoSegmentationDiscriminatorStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoSegmentationDiscriminatorStrategy?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoSegmentationDiscriminatorStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingOptionItems))
                {
                    return new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingOptionItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingOptionItems?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingOptionItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingScopeItems))
                {
                    return new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingScopeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingScopeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingScopeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingTypeItems))
                {
                    return new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingTypeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoInputRequestEmbeddingTypeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingTypeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.MultiInputMediaSourceMediaType))
                {
                    return new global::TwelveLabs.JsonConverters.MultiInputMediaSourceMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.MultiInputMediaSourceMediaType?))
                {
                    return new global::TwelveLabs.JsonConverters.MultiInputMediaSourceMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingOptionJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingOptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsNullableJsonConverter();
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
                    0 => new EmbedV2SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}