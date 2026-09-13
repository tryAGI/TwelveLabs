
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MediaSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioSegmentationFixed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioSegmentation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioSegmentationStrategy), TypeInfoPropertyName = "AudioSegmentationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationDiscriminatorMappingDynamicDynamic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationDiscriminatorMappingFixedFixed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentation), TypeInfoPropertyName = "VideoSegmentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant1Strategy), TypeInfoPropertyName = "VideoSegmentationVariant1Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant2Strategy), TypeInfoPropertyName = "VideoSegmentationVariant2Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationDiscriminatorStrategy), TypeInfoPropertyName = "VideoSegmentationDiscriminatorStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption), TypeInfoPropertyName = "EmbeddingDataEmbeddingOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope), TypeInfoPropertyName = "EmbeddingDataEmbeddingScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems), TypeInfoPropertyName = "EmbeddingAudioMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems), TypeInfoPropertyName = "EmbeddingVideoMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestInputType), TypeInfoPropertyName = "CreateAsyncEmbeddingRequestInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestModelName), TypeInfoPropertyName = "CreateAsyncEmbeddingRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationDiscriminatorMappingDynamicDynamic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationDiscriminatorMappingFixedFixed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentation), TypeInfoPropertyName = "TemporalSegmentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationVariant1Strategy), TypeInfoPropertyName = "TemporalSegmentationVariant1Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationVariant2Strategy), TypeInfoPropertyName = "TemporalSegmentationVariant2Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy), TypeInfoPropertyName = "TemporalSegmentationDiscriminatorStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncTemporalSegmentation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncAudioInputRequestSegmentation), TypeInfoPropertyName = "AsyncAudioInputRequestSegmentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems), TypeInfoPropertyName = "AsyncAudioInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems), TypeInfoPropertyName = "AsyncAudioInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems), TypeInfoPropertyName = "AsyncAudioInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TimeBasedMetadataEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncAudioInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.TimeBasedMetadataEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncVideoInputRequestSegmentation), TypeInfoPropertyName = "AsyncVideoInputRequestSegmentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems), TypeInfoPropertyName = "AsyncVideoInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems), TypeInfoPropertyName = "AsyncVideoInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems), TypeInfoPropertyName = "AsyncVideoInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncVideoInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems), TypeInfoPropertyName = "AsyncDocumentInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems), TypeInfoPropertyName = "AsyncDocumentInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems), TypeInfoPropertyName = "AsyncDocumentInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems), TypeInfoPropertyName = "AsyncImageInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems), TypeInfoPropertyName = "AsyncImageInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems), TypeInfoPropertyName = "AsyncImageInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus), TypeInfoPropertyName = "EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedV2TasksCreateResponse202))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoEmbeddingMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MediaEmbeddingTaskVideoEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioEmbeddingMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MediaEmbeddingTaskAudioEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DocumentEmbeddingMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MediaEmbeddingTaskDocumentEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageEmbeddingMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MediaEmbeddingTaskImageEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MediaEmbeddingTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedV2TasksListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.MediaEmbeddingTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListAsyncEmbeddingTasksRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskResponseStatus), TypeInfoPropertyName = "EmbeddingTaskResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataInputType), TypeInfoPropertyName = "EmbeddingTaskMediaMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems), TypeInfoPropertyName = "AsyncDocumentMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems), TypeInfoPropertyName = "AsyncImageMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadata), TypeInfoPropertyName = "EmbeddingTaskMediaMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioSegmentationStrategy?), TypeInfoPropertyName = "NullableAudioSegmentationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentation?), TypeInfoPropertyName = "NullableVideoSegmentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant1Strategy?), TypeInfoPropertyName = "NullableVideoSegmentationVariant1Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationVariant2Strategy?), TypeInfoPropertyName = "NullableVideoSegmentationVariant2Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationDiscriminatorStrategy?), TypeInfoPropertyName = "NullableVideoSegmentationDiscriminatorStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption?), TypeInfoPropertyName = "NullableEmbeddingDataEmbeddingOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope?), TypeInfoPropertyName = "NullableEmbeddingDataEmbeddingScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems?), TypeInfoPropertyName = "NullableEmbeddingAudioMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems?), TypeInfoPropertyName = "NullableEmbeddingVideoMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestInputType?), TypeInfoPropertyName = "NullableCreateAsyncEmbeddingRequestInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestModelName?), TypeInfoPropertyName = "NullableCreateAsyncEmbeddingRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentation?), TypeInfoPropertyName = "NullableTemporalSegmentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationVariant1Strategy?), TypeInfoPropertyName = "NullableTemporalSegmentationVariant1Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationVariant2Strategy?), TypeInfoPropertyName = "NullableTemporalSegmentationVariant2Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy?), TypeInfoPropertyName = "NullableTemporalSegmentationDiscriminatorStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncAudioInputRequestSegmentation?), TypeInfoPropertyName = "NullableAsyncAudioInputRequestSegmentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems?), TypeInfoPropertyName = "NullableAsyncAudioInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems?), TypeInfoPropertyName = "NullableAsyncAudioInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems?), TypeInfoPropertyName = "NullableAsyncAudioInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncVideoInputRequestSegmentation?), TypeInfoPropertyName = "NullableAsyncVideoInputRequestSegmentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems?), TypeInfoPropertyName = "NullableAsyncVideoInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems?), TypeInfoPropertyName = "NullableAsyncVideoInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems?), TypeInfoPropertyName = "NullableAsyncVideoInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems?), TypeInfoPropertyName = "NullableAsyncDocumentInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems?), TypeInfoPropertyName = "NullableAsyncDocumentInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems?), TypeInfoPropertyName = "NullableAsyncDocumentInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems?), TypeInfoPropertyName = "NullableAsyncImageInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems?), TypeInfoPropertyName = "NullableAsyncImageInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems?), TypeInfoPropertyName = "NullableAsyncImageInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus?), TypeInfoPropertyName = "NullableEmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskResponseStatus?), TypeInfoPropertyName = "NullableEmbeddingTaskResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataInputType?), TypeInfoPropertyName = "NullableEmbeddingTaskMediaMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems?), TypeInfoPropertyName = "NullableAsyncDocumentMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems?), TypeInfoPropertyName = "NullableAsyncImageMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadata?), TypeInfoPropertyName = "NullableEmbeddingTaskMediaMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.TimeBasedMetadataEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.MediaEmbeddingTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>))]
    internal sealed partial class EmbedV2TasksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbedV2TasksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EmbedV2TasksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EmbedV2TasksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TemporalSegmentationJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AsyncAudioInputRequestSegmentationJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AsyncVideoInputRequestSegmentationJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataJsonConverter());
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
                    typeToConvert == typeof(global::TwelveLabs.AudioSegmentationStrategy)

                    || typeToConvert == typeof(global::TwelveLabs.AudioSegmentationStrategy?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant1Strategy)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant1Strategy?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant2Strategy)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationVariant2Strategy?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationDiscriminatorStrategy)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSegmentationDiscriminatorStrategy?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems?)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestInputType)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestModelName)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestModelName?)

                    || typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationVariant1Strategy)

                    || typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationVariant1Strategy?)

                    || typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationVariant2Strategy)

                    || typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationVariant2Strategy?)

                    || typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy)

                    || typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus)

                    || typeToConvert == typeof(global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingTaskResponseStatus)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingTaskResponseStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataInputType)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::TwelveLabs.AudioSegmentationStrategy))
                {
                    return new global::TwelveLabs.JsonConverters.AudioSegmentationStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AudioSegmentationStrategy?))
                {
                    return new global::TwelveLabs.JsonConverters.AudioSegmentationStrategyNullableJsonConverter();
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

                if (typeToConvert == typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestInputType))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestModelName))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestModelName?))
                {
                    return new global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationVariant1Strategy))
                {
                    return new global::TwelveLabs.JsonConverters.TemporalSegmentationVariant1StrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationVariant1Strategy?))
                {
                    return new global::TwelveLabs.JsonConverters.TemporalSegmentationVariant1StrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationVariant2Strategy))
                {
                    return new global::TwelveLabs.JsonConverters.TemporalSegmentationVariant2StrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationVariant2Strategy?))
                {
                    return new global::TwelveLabs.JsonConverters.TemporalSegmentationVariant2StrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy))
                {
                    return new global::TwelveLabs.JsonConverters.TemporalSegmentationDiscriminatorStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy?))
                {
                    return new global::TwelveLabs.JsonConverters.TemporalSegmentationDiscriminatorStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncAudioInputRequestEmbeddingOptionItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncAudioInputRequestEmbeddingOptionItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncAudioInputRequestEmbeddingScopeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncAudioInputRequestEmbeddingScopeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncAudioInputRequestEmbeddingTypeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncAudioInputRequestEmbeddingTypeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncVideoInputRequestEmbeddingOptionItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncVideoInputRequestEmbeddingOptionItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncVideoInputRequestEmbeddingScopeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncVideoInputRequestEmbeddingScopeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncVideoInputRequestEmbeddingTypeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncVideoInputRequestEmbeddingTypeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentInputRequestEmbeddingOptionItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentInputRequestEmbeddingOptionItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentInputRequestEmbeddingTypeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentInputRequestEmbeddingTypeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentInputRequestEmbeddingScopeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentInputRequestEmbeddingScopeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageInputRequestEmbeddingOptionItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageInputRequestEmbeddingOptionItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageInputRequestEmbeddingTypeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageInputRequestEmbeddingTypeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageInputRequestEmbeddingScopeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageInputRequestEmbeddingScopeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus))
                {
                    return new global::TwelveLabs.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingTaskResponseStatus))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingTaskResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingTaskResponseStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingTaskResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataInputType))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentMetadataEmbeddingScopesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentMetadataEmbeddingScopesItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageMetadataEmbeddingScopesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageMetadataEmbeddingScopesItemsNullableJsonConverter();
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
                    0 => new EmbedV2TasksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}