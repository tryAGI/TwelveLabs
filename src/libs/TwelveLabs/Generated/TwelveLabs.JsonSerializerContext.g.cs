
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
            typeof(global::TwelveLabs.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetMethodJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetMethodNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetSourceTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetSourceTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetSourceDetailsProviderJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetSourceDetailsProviderNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetDetailMethodJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetDetailMethodNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetDetailStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetDetailStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetHlsStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetHlsStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetThumbnailStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetThumbnailStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetsGetParametersAssetTypesSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetsGetParametersAssetTypesSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAssetUploadRequestTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAssetUploadRequestTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.MultipartUploadStatusTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.MultipartUploadStatusTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ChunkInfoStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ChunkInfoStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CompletedChunkProofTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CompletedChunkProofTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TasksGetParametersStatusSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TasksGetParametersStatusSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.HlsObjectStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.HlsObjectStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProviderJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProviderNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionProviderJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionProviderNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportItemStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportItemStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportProviderJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportProviderNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportDetailProviderJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportDetailProviderNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigDiscriminatorTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoSearchModalityJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoSearchModalityNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseInputItemTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseInputItemTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseInputItemRoleJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseInputItemRoleNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseSelectionKindJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseSelectionKindNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextResponseFormatTextTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextResponseFormatTextTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextParamFormatDiscriminatorTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextParamFormatDiscriminatorTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseObjectTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseObjectTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputItemTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputItemTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputItemRoleJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputItemRoleNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputContentPartTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputContentPartTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamResponseEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamResponseEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputItemAddedEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputItemAddedEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamContentPartAddedEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamContentPartAddedEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDeltaEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDeltaEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDoneEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDoneEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamContentPartDoneEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamContentPartDoneEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputItemDoneEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputItemDoneEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamFuncCallArgsDoneEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamFuncCallArgsDoneEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamEventDiscriminatorTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexedAssetDetailedStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexedAssetDetailedStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexedAssetStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexedAssetStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioSegmentationStrategyJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioSegmentationStrategyNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingOptionItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingOptionItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingScopeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingScopeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingTypeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingTypeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingOptionItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingOptionItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingScopeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingScopeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingTypeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingTypeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.MultiInputMediaSourceMediaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.MultiInputMediaSourceMediaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingOptionJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingOptionNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingScopeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingScopeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingImageMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingImageMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTextImageMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTextImageMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingMultiInputMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingMultiInputMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskResponseStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskResponseStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzePostRequestBodyContentApplicationJsonSchemaModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzePostRequestBodyContentApplicationJsonSchemaModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant1TypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant1TypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant2TypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant2TypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant3TypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant3TypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextDiscriminatorTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextDiscriminatorTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SyncResponseFormatTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SyncResponseFormatTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamStartResponseEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamStartResponseEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamTextResponseEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamTextResponseEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamEndResponseEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamEndResponseEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.FinishReasonJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.FinishReasonNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamAnalyzeResponseDiscriminatorEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamAnalyzeResponseDiscriminatorEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldFormatJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldFormatNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatSegmentTimeFormatJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatSegmentTimeFormatNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTasksGetParametersAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTasksGetParametersAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseVideoSourceTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseVideoSourceTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsResponseFormatTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsResponseFormatTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchVideoContextTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchVideoContextTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeBatchesGetParametersAnalysisModeSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeBatchesGetParametersAnalysisModeSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeBatchStatusResponseAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeBatchStatusResponseAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchItemStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchItemStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextParamFormatJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamEventJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdVideosGetParametersUserMetadataSchemaJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamAnalyzeResponseJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeResponse200JsonConverter),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.EmbeddingDataEmbeddingOption?, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.EmbeddingDataEmbeddingScope?, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseVideoSource, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParams, object>),

            typeof(global::TwelveLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod), TypeInfoPropertyName = "AssetsPostRequestBodyContentMultipartFormDataSchemaMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetMethod), TypeInfoPropertyName = "AssetMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetStatus), TypeInfoPropertyName = "AssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UserMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceType), TypeInfoPropertyName = "AssetSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceDetailsProvider), TypeInfoPropertyName = "AssetSourceDetailsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.Asset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailMethod), TypeInfoPropertyName = "AssetDetailMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailStatus), TypeInfoPropertyName = "AssetDetailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHlsStatus), TypeInfoPropertyName = "AssetHlsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHLS))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnailStatus), TypeInfoPropertyName = "AssetThumbnailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TechnicalMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AudioStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems), TypeInfoPropertyName = "AssetsGetParametersAssetTypesSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PageInfo))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequestType), TypeInfoPropertyName = "CreateAssetUploadRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PresignedURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.PresignedURLChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateMultipartUploadRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateMultipartUploadRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateMultipartUploadRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MultipartUploadStatusType), TypeInfoPropertyName = "MultipartUploadStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ChunkInfoStatus), TypeInfoPropertyName = "ChunkInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ChunkInfo))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksCreateResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateVideoIndexingTaskRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksGetParametersStatusSchemaItems), TypeInfoPropertyName = "TasksGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoIndexingTaskSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoIndexingTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksGetResponsesContentApplicationJsonSchemaPageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoIndexingTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListVideoIndexingTasksRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksTaskIdGetResponsesContentApplicationJsonSchemaSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HlsObjectStatus), TypeInfoPropertyName = "HlsObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HLSObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksRetrieveResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveVideoIndexingTaskRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteVideoIndexingTaskRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider), TypeInfoPropertyName = "ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DataConnectorsAuthorizeConnectionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AuthorizeConnectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionProvider), TypeInfoPropertyName = "ConnectionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionStatus), TypeInfoPropertyName = "ConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.Connection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DataConnectorsListConnectionsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.Connection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListConnectionsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveConnectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveConnectionRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteConnectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteConnectionRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DataConnectorsCreateConnectionPickerTokenResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateConnectionPickerTokenRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateConnectionPickerTokenRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateConnectionPickerTokenRequestConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportItemStatus), TypeInfoPropertyName = "ImportItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportItemError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ImportItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportFilesRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportFilesRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportFilesRequestConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportProvider), TypeInfoPropertyName = "ImportProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.Import))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportsListImportsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.Import>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListImportsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListImportsRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportDetailProvider), TypeInfoPropertyName = "ImportDetailProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveImportRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveImportRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsGetParametersSortBy), TypeInfoPropertyName = "EntityCollectionsGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListEntityCollectionsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEntityCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveEntityCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateEntityCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteEntityCollectionRequestBadRequestError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType), TypeInfoPropertyName = "EnrichmentConfigJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType), TypeInfoPropertyName = "EnrichmentConfigJsonSchemaJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigDescriptionType), TypeInfoPropertyName = "EnrichmentConfigDescriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfig), TypeInfoPropertyName = "EnrichmentConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType), TypeInfoPropertyName = "EnrichmentConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IngestionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateKnowledgeStoreRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy), TypeInfoPropertyName = "KnowledgeStoresGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListKnowledgeStoresRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveKnowledgeStoreRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateKnowledgeStoreRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteKnowledgeStoreRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreSearchQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemAssetType), TypeInfoPropertyName = "KnowledgeStoreItemAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetTypeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemAssetType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ItemIdFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSearchModality), TypeInfoPropertyName = "VideoSearchModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy), TypeInfoPropertyName = "SearchKnowledgeStoreRequestGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSearchSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSearchItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageSearchSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageSearchItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHit), TypeInfoPropertyName = "SearchKnowledgeStoreHit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType), TypeInfoPropertyName = "SearchKnowledgeStoreHitVariant1AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType), TypeInfoPropertyName = "SearchKnowledgeStoreHitVariant2AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType), TypeInfoPropertyName = "SearchKnowledgeStoreHitDiscriminatorAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchKnowledgeStoreHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGoneError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemStatus), TypeInfoPropertyName = "KnowledgeStoreItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoMetadataAssetType), TypeInfoPropertyName = "VideoMetadataAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageMetadataAssetType), TypeInfoPropertyName = "ImageMetadataAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadata), TypeInfoPropertyName = "KnowledgeStoreItemSystemMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType), TypeInfoPropertyName = "KnowledgeStoreItemSystemMetadataDiscriminatorAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateKnowledgeStoreItemRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy), TypeInfoPropertyName = "KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems), TypeInfoPropertyName = "KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemsListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListKnowledgeStoreItemsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveKnowledgeStoreItemRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteKnowledgeStoreItemRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateKnowledgeStoreItemCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy), TypeInfoPropertyName = "KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemCollectionsListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListKnowledgeStoreItemCollectionsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveKnowledgeStoreItemCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateKnowledgeStoreItemCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteKnowledgeStoreItemCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemCollectionsListItemsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListKnowledgeStoreItemCollectionItemsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AddItemsToKnowledgeStoreItemCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RemoveItemsFromKnowledgeStoreItemCollectionRequestBadRequestError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStatus), TypeInfoPropertyName = "ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputItemType), TypeInfoPropertyName = "ResponseOutputItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputItemRole), TypeInfoPropertyName = "ResponseOutputItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputContentPartType), TypeInfoPropertyName = "ResponseOutputContentPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputContentPart))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesCreateResponse201))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexModelsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.Index))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.Index>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListIndexesRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveIndexRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateIndexRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteIndexRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexedAssetsCreateResponse202))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexedAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexedAssetRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexedAssetRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems), TypeInfoPropertyName = "IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedStatus), TypeInfoPropertyName = "IndexedAssetDetailedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedSystemMetadata))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosGetParametersDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosGetParametersFps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosGetParametersWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosGetParametersHeight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosGetParametersSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema), TypeInfoPropertyName = "IndexesIndexIdVideosGetParametersUserMetadataSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoVectorSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoVector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesVideosListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoVector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListVideosRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems), TypeInfoPropertyName = "IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbeddingVideoEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesVideosRetrieveResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveVideoInformationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveVideoInformationRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PartialUpdateVideoInformationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteVideoInformationRequestBadRequestError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentation))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.EmbeddingDataEmbeddingOption?, object>), TypeInfoPropertyName = "OneOfEmbeddingDataEmbeddingOptionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.EmbeddingDataEmbeddingScope?, object>), TypeInfoPropertyName = "OneOfEmbeddingDataEmbeddingScopeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingImageMetadataInputType), TypeInfoPropertyName = "EmbeddingImageMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType), TypeInfoPropertyName = "EmbeddingMediaMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTextImageMetadataInputType), TypeInfoPropertyName = "EmbeddingTextImageMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadataInputType), TypeInfoPropertyName = "EmbeddingAudioMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems), TypeInfoPropertyName = "EmbeddingAudioMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadataInputType), TypeInfoPropertyName = "EmbeddingVideoMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems), TypeInfoPropertyName = "EmbeddingVideoMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMultiInputMetadataInputType), TypeInfoPropertyName = "EmbeddingMultiInputMetadataInputType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestInputType), TypeInfoPropertyName = "CreateAsyncEmbeddingRequestInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestModelName), TypeInfoPropertyName = "CreateAsyncEmbeddingRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus), TypeInfoPropertyName = "EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedV2TasksCreateResponse202))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoEmbeddingMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MediaEmbeddingTaskVideoEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioEmbeddingMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MediaEmbeddingTaskAudioEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MediaEmbeddingTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedV2TasksListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.MediaEmbeddingTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListAsyncEmbeddingTasksRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskResponseStatus), TypeInfoPropertyName = "EmbeddingTaskResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataInputType), TypeInfoPropertyName = "EmbeddingTaskMediaMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadata), TypeInfoPropertyName = "EmbeddingTaskMediaMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems), TypeInfoPropertyName = "EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksCreateResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateVideoEmbeddingTaskRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksGetResponsesContentApplicationJsonSchemaPageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListVideoEmbeddingTasksRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksTaskIdStatusGetResponsesContentApplicationJsonSchemaVideoEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksStatusResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveVideoEmbeddingTaskRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems), TypeInfoPropertyName = "EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksRetrieveResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveVideoEmbeddingRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BaseSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextEmbeddingResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.BaseSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BaseEmbeddingMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageEmbeddingResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioEmbeddingResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AudioSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateTextImageAudioEmbeddingRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName), TypeInfoPropertyName = "AnalyzePostRequestBodyContentApplicationJsonSchemaModelName2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SyncResponseFormatType), TypeInfoPropertyName = "SyncResponseFormatType2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::TwelveLabs.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetMethodJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetMethodNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetSourceTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetSourceTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetSourceDetailsProviderJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetSourceDetailsProviderNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetDetailMethodJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetDetailMethodNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetDetailStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetDetailStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetHlsStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetHlsStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetThumbnailStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetThumbnailStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetsGetParametersAssetTypesSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AssetsGetParametersAssetTypesSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAssetUploadRequestTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAssetUploadRequestTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.MultipartUploadStatusTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.MultipartUploadStatusTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ChunkInfoStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ChunkInfoStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CompletedChunkProofTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CompletedChunkProofTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TasksGetParametersStatusSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TasksGetParametersStatusSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.HlsObjectStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.HlsObjectStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProviderJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProviderNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionProviderJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionProviderNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ConnectionStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportItemStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportItemStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportProviderJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportProviderNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportDetailProviderJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImportDetailProviderNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigDiscriminatorTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoSearchModalityJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoSearchModalityNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseInputItemTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseInputItemTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseInputItemRoleJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseInputItemRoleNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseSelectionKindJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseSelectionKindNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextResponseFormatTextTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextResponseFormatTextTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextParamFormatDiscriminatorTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextParamFormatDiscriminatorTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseObjectTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseObjectTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputItemTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputItemTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputItemRoleJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputItemRoleNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputContentPartTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseOutputContentPartTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamResponseEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamResponseEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputItemAddedEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputItemAddedEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamContentPartAddedEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamContentPartAddedEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDeltaEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDeltaEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDoneEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDoneEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamContentPartDoneEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamContentPartDoneEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputItemDoneEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputItemDoneEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamFuncCallArgsDoneEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamFuncCallArgsDoneEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamEventDiscriminatorTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexedAssetDetailedStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexedAssetDetailedStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexedAssetStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexedAssetStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioSegmentationStrategyJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioSegmentationStrategyNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingOptionItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingOptionItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingScopeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingScopeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingTypeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingTypeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingOptionItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingOptionItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingScopeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingScopeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingTypeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingTypeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.MultiInputMediaSourceMediaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.MultiInputMediaSourceMediaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingOptionJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingOptionNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingScopeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingScopeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingImageMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingImageMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTextImageMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTextImageMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingMultiInputMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingMultiInputMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskResponseStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskResponseStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataInputTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataInputTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzePostRequestBodyContentApplicationJsonSchemaModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzePostRequestBodyContentApplicationJsonSchemaModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant1TypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant1TypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant2TypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant2TypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant3TypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextVariant3TypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextDiscriminatorTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextDiscriminatorTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SyncResponseFormatTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SyncResponseFormatTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamStartResponseEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamStartResponseEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamTextResponseEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamTextResponseEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamEndResponseEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamEndResponseEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.FinishReasonJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.FinishReasonNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamAnalyzeResponseDiscriminatorEventTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamAnalyzeResponseDiscriminatorEventTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldFormatJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldFormatNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatSegmentTimeFormatJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatSegmentTimeFormatNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTasksGetParametersAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTasksGetParametersAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseVideoSourceTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseVideoSourceTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsResponseFormatTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsResponseFormatTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchVideoContextTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchVideoContextTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeBatchesGetParametersAnalysisModeSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeBatchesGetParametersAnalysisModeSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeBatchStatusResponseAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeBatchStatusResponseAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchItemStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.BatchItemStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.TextParamFormatJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.ResponseStreamEventJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdVideosGetParametersUserMetadataSchemaJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.StreamAnalyzeResponseJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AnalyzeResponse200JsonConverter),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.EmbeddingDataEmbeddingOption?, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.EmbeddingDataEmbeddingScope?, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseVideoSource, object>),

            typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParams, object>),

            typeof(global::TwelveLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SyncResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SyncResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamStartResponseEventType), TypeInfoPropertyName = "StreamStartResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamStartResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamTextResponseEventType), TypeInfoPropertyName = "StreamTextResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamEndResponseEventType), TypeInfoPropertyName = "StreamEndResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TokenUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamEndResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamAnalyzeResponse), TypeInfoPropertyName = "StreamAnalyzeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamAnalyzeResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamAnalyzeResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamAnalyzeResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamAnalyzeResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType), TypeInfoPropertyName = "StreamAnalyzeResponseDiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.NonStreamAnalyzeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeResponse200), TypeInfoPropertyName = "AnalyzeResponse2002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.GenerateTextRepresentationRequestNotFoundError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata, object>), TypeInfoPropertyName = "OneOfAnalyzeTaskResponseVideoSourceSystemMetadataObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema, object>), TypeInfoPropertyName = "OneOfAnalyzeTaskResponseRequestParamsResponseFormatJsonSchemaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2, object>), TypeInfoPropertyName = "OneOfAnalyzeTaskResponseRequestParamsPromptV2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat, object>), TypeInfoPropertyName = "OneOfAnalyzeTaskResponseRequestParamsResponseFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResultUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskWebhookInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseVideoSource, object>), TypeInfoPropertyName = "OneOfAnalyzeTaskResponseVideoSourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParams, object>), TypeInfoPropertyName = "OneOfAnalyzeTaskResponseRequestParamsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeAsyncTasksListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListAsyncAnalysisTasksRequestBadRequestError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateUserMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ReplaceUserMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AuthorizeConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportFilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateBulkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteAssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AddItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RemoveItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.TasksGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.BatchStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod?), TypeInfoPropertyName = "NullableAssetsPostRequestBodyContentMultipartFormDataSchemaMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetMethod?), TypeInfoPropertyName = "NullableAssetMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetStatus?), TypeInfoPropertyName = "NullableAssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceType?), TypeInfoPropertyName = "NullableAssetSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceDetailsProvider?), TypeInfoPropertyName = "NullableAssetSourceDetailsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailMethod?), TypeInfoPropertyName = "NullableAssetDetailMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailStatus?), TypeInfoPropertyName = "NullableAssetDetailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHlsStatus?), TypeInfoPropertyName = "NullableAssetHlsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnailStatus?), TypeInfoPropertyName = "NullableAssetThumbnailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems?), TypeInfoPropertyName = "NullableAssetsGetParametersAssetTypesSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequestType?), TypeInfoPropertyName = "NullableCreateAssetUploadRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MultipartUploadStatusType?), TypeInfoPropertyName = "NullableMultipartUploadStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ChunkInfoStatus?), TypeInfoPropertyName = "NullableChunkInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CompletedChunkProofType?), TypeInfoPropertyName = "NullableCompletedChunkProofType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksGetParametersStatusSchemaItems?), TypeInfoPropertyName = "NullableTasksGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HlsObjectStatus?), TypeInfoPropertyName = "NullableHlsObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider?), TypeInfoPropertyName = "NullableConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionProvider?), TypeInfoPropertyName = "NullableConnectionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionStatus?), TypeInfoPropertyName = "NullableConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportItemStatus?), TypeInfoPropertyName = "NullableImportItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportProvider?), TypeInfoPropertyName = "NullableImportProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportDetailProvider?), TypeInfoPropertyName = "NullableImportDetailProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsGetParametersSortBy?), TypeInfoPropertyName = "NullableEntityCollectionsGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus?), TypeInfoPropertyName = "NullableEntityCollectionsEntityCollectionIdEntitiesGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy?), TypeInfoPropertyName = "NullableEntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityStatus?), TypeInfoPropertyName = "NullableEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType?), TypeInfoPropertyName = "NullableEnrichmentConfigJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType?), TypeInfoPropertyName = "NullableEnrichmentConfigJsonSchemaJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigDescriptionType?), TypeInfoPropertyName = "NullableEnrichmentConfigDescriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfig?), TypeInfoPropertyName = "NullableEnrichmentConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType?), TypeInfoPropertyName = "NullableEnrichmentConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy?), TypeInfoPropertyName = "NullableKnowledgeStoresGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemAssetType?), TypeInfoPropertyName = "NullableKnowledgeStoreItemAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSearchModality?), TypeInfoPropertyName = "NullableVideoSearchModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy?), TypeInfoPropertyName = "NullableSearchKnowledgeStoreRequestGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHit?), TypeInfoPropertyName = "NullableSearchKnowledgeStoreHit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType?), TypeInfoPropertyName = "NullableSearchKnowledgeStoreHitVariant1AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType?), TypeInfoPropertyName = "NullableSearchKnowledgeStoreHitVariant2AssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType?), TypeInfoPropertyName = "NullableSearchKnowledgeStoreHitDiscriminatorAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemStatus?), TypeInfoPropertyName = "NullableKnowledgeStoreItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoMetadataAssetType?), TypeInfoPropertyName = "NullableVideoMetadataAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImageMetadataAssetType?), TypeInfoPropertyName = "NullableImageMetadataAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadata?), TypeInfoPropertyName = "NullableKnowledgeStoreItemSystemMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType?), TypeInfoPropertyName = "NullableKnowledgeStoreItemSystemMetadataDiscriminatorAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy?), TypeInfoPropertyName = "NullableKnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems?), TypeInfoPropertyName = "NullableKnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy?), TypeInfoPropertyName = "NullableKnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseInputItemType?), TypeInfoPropertyName = "NullableResponseInputItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseInputItemRole?), TypeInfoPropertyName = "NullableResponseInputItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems?), TypeInfoPropertyName = "NullableResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseSelectionKind?), TypeInfoPropertyName = "NullableResponseSelectionKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextResponseFormatTextType?), TypeInfoPropertyName = "NullableTextResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableTextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextParamFormat?), TypeInfoPropertyName = "NullableTextParamFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TextParamFormatDiscriminatorType?), TypeInfoPropertyName = "NullableTextParamFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseObjectType?), TypeInfoPropertyName = "NullableResponseObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseStatus?), TypeInfoPropertyName = "NullableResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputItemType?), TypeInfoPropertyName = "NullableResponseOutputItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputItemRole?), TypeInfoPropertyName = "NullableResponseOutputItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ResponseOutputContentPartType?), TypeInfoPropertyName = "NullableResponseOutputContentPartType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems?), TypeInfoPropertyName = "NullableIndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedStatus?), TypeInfoPropertyName = "NullableIndexedAssetDetailedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems?), TypeInfoPropertyName = "NullableIndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema?), TypeInfoPropertyName = "NullableIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetStatus?), TypeInfoPropertyName = "NullableIndexedAssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema?), TypeInfoPropertyName = "NullableIndexesIndexIdVideosGetParametersUserMetadataSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems?), TypeInfoPropertyName = "NullableIndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator?), TypeInfoPropertyName = "NullableSearchPostRequestBodyContentMultipartFormDataSchemaOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEmbeddingsRequestInputType?), TypeInfoPropertyName = "NullableCreateEmbeddingsRequestInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEmbeddingsRequestModelName?), TypeInfoPropertyName = "NullableCreateEmbeddingsRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioSegmentationStrategy?), TypeInfoPropertyName = "NullableAudioSegmentationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioInputRequestEmbeddingOptionItems?), TypeInfoPropertyName = "NullableAudioInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioInputRequestEmbeddingScopeItems?), TypeInfoPropertyName = "NullableAudioInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AudioInputRequestEmbeddingTypeItems?), TypeInfoPropertyName = "NullableAudioInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoInputRequestEmbeddingOptionItems?), TypeInfoPropertyName = "NullableVideoInputRequestEmbeddingOptionItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoInputRequestEmbeddingScopeItems?), TypeInfoPropertyName = "NullableVideoInputRequestEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoInputRequestEmbeddingTypeItems?), TypeInfoPropertyName = "NullableVideoInputRequestEmbeddingTypeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MultiInputMediaSourceMediaType?), TypeInfoPropertyName = "NullableMultiInputMediaSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingDataEmbeddingOption?), TypeInfoPropertyName = "NullableEmbeddingDataEmbeddingOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingDataEmbeddingScope?), TypeInfoPropertyName = "NullableEmbeddingDataEmbeddingScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.EmbeddingDataEmbeddingOption?, object>?), TypeInfoPropertyName = "NullableOneOfEmbeddingDataEmbeddingOptionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.EmbeddingDataEmbeddingScope?, object>?), TypeInfoPropertyName = "NullableOneOfEmbeddingDataEmbeddingScopeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingImageMetadataInputType?), TypeInfoPropertyName = "NullableEmbeddingImageMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType?), TypeInfoPropertyName = "NullableEmbeddingMediaMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTextImageMetadataInputType?), TypeInfoPropertyName = "NullableEmbeddingTextImageMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadataInputType?), TypeInfoPropertyName = "NullableEmbeddingAudioMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems?), TypeInfoPropertyName = "NullableEmbeddingAudioMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadataInputType?), TypeInfoPropertyName = "NullableEmbeddingVideoMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems?), TypeInfoPropertyName = "NullableEmbeddingVideoMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMultiInputMetadataInputType?), TypeInfoPropertyName = "NullableEmbeddingMultiInputMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadata?), TypeInfoPropertyName = "NullableEmbeddingMediaMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestInputType?), TypeInfoPropertyName = "NullableCreateAsyncEmbeddingRequestInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncEmbeddingRequestModelName?), TypeInfoPropertyName = "NullableCreateAsyncEmbeddingRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus?), TypeInfoPropertyName = "NullableEmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskResponseStatus?), TypeInfoPropertyName = "NullableEmbeddingTaskResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataInputType?), TypeInfoPropertyName = "NullableEmbeddingTaskMediaMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadata?), TypeInfoPropertyName = "NullableEmbeddingTaskMediaMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems?), TypeInfoPropertyName = "NullableEmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems?), TypeInfoPropertyName = "NullableEmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName?), TypeInfoPropertyName = "NullableAnalyzePostRequestBodyContentApplicationJsonSchemaModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContext?), TypeInfoPropertyName = "NullableVideoContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant1Type?), TypeInfoPropertyName = "NullableVideoContextVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant2Type?), TypeInfoPropertyName = "NullableVideoContextVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextVariant3Type?), TypeInfoPropertyName = "NullableVideoContextVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextDiscriminatorType?), TypeInfoPropertyName = "NullableVideoContextDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SmeMediaSourceMediaType?), TypeInfoPropertyName = "NullableSmeMediaSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SyncResponseFormatType?), TypeInfoPropertyName = "NullableSyncResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamStartResponseEventType?), TypeInfoPropertyName = "NullableStreamStartResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamTextResponseEventType?), TypeInfoPropertyName = "NullableStreamTextResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamEndResponseEventType?), TypeInfoPropertyName = "NullableStreamEndResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.FinishReason?), TypeInfoPropertyName = "NullableFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamAnalyzeResponse?), TypeInfoPropertyName = "NullableStreamAnalyzeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType?), TypeInfoPropertyName = "NullableStreamAnalyzeResponseDiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeResponse200?), TypeInfoPropertyName = "NullableAnalyzeResponse2002")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata, object>?), TypeInfoPropertyName = "NullableOneOfAnalyzeTaskResponseVideoSourceSystemMetadataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode?), TypeInfoPropertyName = "NullableAnalyzeTaskResponseRequestParamsAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType?), TypeInfoPropertyName = "NullableAnalyzeTaskResponseRequestParamsResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema, object>?), TypeInfoPropertyName = "NullableOneOfAnalyzeTaskResponseRequestParamsResponseFormatJsonSchemaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2, object>?), TypeInfoPropertyName = "NullableOneOfAnalyzeTaskResponseRequestParamsPromptV2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat, object>?), TypeInfoPropertyName = "NullableOneOfAnalyzeTaskResponseRequestParamsResponseFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseVideoSource, object>?), TypeInfoPropertyName = "NullableOneOfAnalyzeTaskResponseVideoSourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParams, object>?), TypeInfoPropertyName = "NullableOneOfAnalyzeTaskResponseRequestParamsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeBatchRequestModelName?), TypeInfoPropertyName = "NullableCreateAnalyzeBatchRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode?), TypeInfoPropertyName = "NullableCreateAnalyzeBatchRequestAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchVideoContextType?), TypeInfoPropertyName = "NullableBatchVideoContextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchStatus?), TypeInfoPropertyName = "NullableBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems?), TypeInfoPropertyName = "NullableAnalyzeBatchesGetParametersAnalysisModeSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode?), TypeInfoPropertyName = "NullableAnalyzeBatchStatusResponseAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchItemStatus?), TypeInfoPropertyName = "NullableBatchItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AudioStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.PresignedURLChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ChunkInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IncompleteUploadSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.CompletedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoIndexingTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.Connection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ImportItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.Import>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EntityCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItemAssetType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoSearchModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchKnowledgeStoreHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItemCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponseOutputContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.Index>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.TranscriptionDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexedAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexedAssetSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoVector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchItemClipsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.MediaEmbeddingTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BaseSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AudioSegment>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BatchItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.CreatedBatchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchStatusResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponseInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponseSelection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.TasksGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BatchStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetMethodJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetMethodNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetSourceTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetSourceDetailsProviderJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetSourceDetailsProviderNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetDetailMethodJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetDetailMethodNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetDetailStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetDetailStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetHlsStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetHlsStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetThumbnailStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetThumbnailStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetsGetParametersAssetTypesSchemaItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AssetsGetParametersAssetTypesSchemaItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAssetUploadRequestTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAssetUploadRequestTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.MultipartUploadStatusTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.MultipartUploadStatusTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ChunkInfoStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ChunkInfoStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CompletedChunkProofTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CompletedChunkProofTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TasksGetParametersStatusSchemaItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TasksGetParametersStatusSchemaItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.HlsObjectStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.HlsObjectStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProviderJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProviderNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ConnectionProviderJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ConnectionProviderNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ConnectionStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ConnectionStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ImportItemStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ImportItemStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ImportProviderJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ImportProviderNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ImportDetailProviderJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ImportDetailProviderNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EntityCollectionsGetParametersSortByJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EntityCollectionsGetParametersSortByNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EntityStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EntityStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoresGetParametersSortByJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoresGetParametersSortByNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoSearchModalityJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoSearchModalityNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortByJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortByNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseInputItemTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseInputItemTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseInputItemRoleJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseInputItemRoleNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseSelectionKindJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseSelectionKindNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TextResponseFormatTextTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TextResponseFormatTextTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TextParamFormatDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TextParamFormatDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseObjectTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseOutputItemTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseOutputItemTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseOutputItemRoleJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseOutputItemRoleNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseOutputContentPartTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseOutputContentPartTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamResponseEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamResponseEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamOutputItemAddedEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamOutputItemAddedEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamContentPartAddedEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamContentPartAddedEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDeltaEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDeltaEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDoneEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamContentPartDoneEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamContentPartDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamOutputItemDoneEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamOutputItemDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamFuncCallArgsDoneEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamFuncCallArgsDoneEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamEventDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamEventDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexedAssetDetailedStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexedAssetDetailedStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexedAssetStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexedAssetStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestInputTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestInputTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestModelNameJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestModelNameNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AudioSegmentationStrategyJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AudioSegmentationStrategyNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingOptionItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingOptionItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingScopeItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingScopeItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingTypeItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AudioInputRequestEmbeddingTypeItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingOptionItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingOptionItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingScopeItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingScopeItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingTypeItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoInputRequestEmbeddingTypeItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.MultiInputMediaSourceMediaTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.MultiInputMediaSourceMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingOptionJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingOptionNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingScopeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingDataEmbeddingScopeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingImageMetadataInputTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingImageMetadataInputTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingTextImageMetadataInputTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingTextImageMetadataInputTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataInputTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataInputTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataInputTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataInputTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingMultiInputMetadataInputTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingMultiInputMetadataInputTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestInputTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestInputTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestModelNameJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestModelNameNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingTaskResponseStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingTaskResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataInputTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataInputTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzePostRequestBodyContentApplicationJsonSchemaModelNameJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzePostRequestBodyContentApplicationJsonSchemaModelNameNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextVariant1TypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextVariant2TypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextVariant3TypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SyncResponseFormatTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SyncResponseFormatTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.StreamStartResponseEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.StreamStartResponseEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.StreamTextResponseEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.StreamTextResponseEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.StreamEndResponseEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.StreamEndResponseEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.FinishReasonJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.FinishReasonNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.StreamAnalyzeResponseDiscriminatorEventTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.StreamAnalyzeResponseDiscriminatorEventTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SegmentFieldTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SegmentFieldTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SegmentFieldFormatJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SegmentFieldFormatNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AsyncResponseFormatSegmentTimeFormatJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AsyncResponseFormatSegmentTimeFormatNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeTaskStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeTaskStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeTasksGetParametersAnalysisModeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeTasksGetParametersAnalysisModeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseVideoSourceTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseVideoSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsAnalysisModeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsAnalysisModeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsResponseFormatTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsResponseFormatTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestModelNameJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestModelNameNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestAnalysisModeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestAnalysisModeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.BatchVideoContextTypeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.BatchVideoContextTypeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.BatchStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.BatchStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeBatchesGetParametersAnalysisModeSchemaItemsJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeBatchesGetParametersAnalysisModeSchemaItemsNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeBatchStatusResponseAnalysisModeJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeBatchStatusResponseAnalysisModeNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.BatchItemStatusJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.BatchItemStatusNullableJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TextParamFormatJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamEventJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdVideosGetParametersUserMetadataSchemaJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.StreamAnalyzeResponseJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeResponse200JsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.EmbeddingDataEmbeddingOption?, object>());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.EmbeddingDataEmbeddingScope?, object>());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata, object>());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema, object>());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2, object>());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat, object>());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseVideoSource, object>());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParams, object>());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}