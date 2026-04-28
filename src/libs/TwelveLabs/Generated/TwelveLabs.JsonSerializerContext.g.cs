
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

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexedAssetStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexedAssetStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityStatusJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EntityStatusNullableJsonConverter),

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

            typeof(global::TwelveLabs.JsonConverters.VideoSegmentation0StrategyJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoSegmentation0StrategyNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoSegmentation1StrategyJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoSegmentation1StrategyNullableJsonConverter),

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

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextOneOf0TypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextOneOf0TypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextOneOf1TypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextOneOf1TypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextOneOf2TypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoContextOneOf2TypeNullableJsonConverter),

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

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldTypeNullableJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeNullableJsonConverter),

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

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.IndexesIndexIdVideosGetParametersUserMetadataSchemaJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileJsonConverter),

            typeof(global::TwelveLabs.JsonConverters.VideoSegmentationJsonConverter),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesCreateResponse201))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexModelsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.Index))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.Index>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListIndexesRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveIndexRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesUpdateResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateIndexRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesDeleteResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteIndexRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod), TypeInfoPropertyName = "AssetsPostRequestBodyContentMultipartFormDataSchemaMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetMethod), TypeInfoPropertyName = "AssetMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetStatus), TypeInfoPropertyName = "AssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.Asset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHlsStatus), TypeInfoPropertyName = "AssetHlsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHLS))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnailStatus), TypeInfoPropertyName = "AssetThumbnailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems), TypeInfoPropertyName = "AssetsGetParametersAssetTypesSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AssetDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListAssetsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsDeleteResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteAssetRequestConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequestType), TypeInfoPropertyName = "CreateAssetUploadRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PresignedURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.PresignedURLChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HlsObjectStatus), TypeInfoPropertyName = "HlsObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HLSObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksRetrieveResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveVideoIndexingTaskRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksDeleteResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteVideoIndexingTaskRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexedAssetsCreateResponse202))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexedAssetRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexedAssetRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateIndexedAssetRequestInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems), TypeInfoPropertyName = "IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetStatus), TypeInfoPropertyName = "IndexedAssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedEmbeddingVideoEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TranscriptionDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.TranscriptionDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveIndexedAssetInformationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveIndexedAssetInformationRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems), TypeInfoPropertyName = "IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersFps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersWidth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersHeight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema), TypeInfoPropertyName = "IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexedAssetsListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListIndexedAssetsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexedAssetsDeleteResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteIndexedAssetInformationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UserMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexedAssetsUpdateResponse204))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesVideosUpdateResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PartialUpdateVideoInformationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesVideosDeleteResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteVideoInformationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsGetParametersSortBy), TypeInfoPropertyName = "EntityCollectionsGetParametersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListEntityCollectionsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateEntityCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveEntityCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateEntityCollectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsDeleteResponse204))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntitiesDeleteResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteEntityRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AddEntityAssetsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RemoveEntityAssetsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EntityCollectionsEntitiesListByAssetResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListEntitiesByAssetRequestBadRequestError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationOneOf0Dynamic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentation0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentation0Strategy), TypeInfoPropertyName = "VideoSegmentation0Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentationOneOf1Fixed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentation1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentation1Strategy), TypeInfoPropertyName = "VideoSegmentation1Strategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoSegmentation), TypeInfoPropertyName = "VideoSegmentation2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingImageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTextImageMetadataInputType), TypeInfoPropertyName = "EmbeddingTextImageMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTextImageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadataInputType), TypeInfoPropertyName = "EmbeddingAudioMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems), TypeInfoPropertyName = "EmbeddingAudioMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingAudioMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadataInputType), TypeInfoPropertyName = "EmbeddingVideoMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems), TypeInfoPropertyName = "EmbeddingVideoMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingVideoMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMultiInputMetadataInputType), TypeInfoPropertyName = "EmbeddingMultiInputMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMultiInputMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingMediaMetadata), TypeInfoPropertyName = "EmbeddingMediaMetadata2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadata), TypeInfoPropertyName = "EmbeddingTaskMediaMetadata2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoEmbeddingTaskVideoEmbedding))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextOneOf0Type), TypeInfoPropertyName = "VideoContextOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContext0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextOneOf1Type), TypeInfoPropertyName = "VideoContextOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContext1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContextOneOf2Type), TypeInfoPropertyName = "VideoContextOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContext2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoContext), TypeInfoPropertyName = "VideoContext2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SyncResponseFormatType), TypeInfoPropertyName = "SyncResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SyncResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SyncResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamStartResponseEventType), TypeInfoPropertyName = "StreamStartResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamStartResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamStartResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamTextResponseEventType), TypeInfoPropertyName = "StreamTextResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamTextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamEndResponseEventType), TypeInfoPropertyName = "StreamEndResponseEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.FinishReason), TypeInfoPropertyName = "FinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TokenUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamEndResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamEndResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.StreamAnalyzeResponse), TypeInfoPropertyName = "StreamAnalyzeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.NonStreamAnalyzeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeResponse200), TypeInfoPropertyName = "AnalyzeResponse2002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestModelName), TypeInfoPropertyName = "CreateAsyncAnalyzeRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SmeMediaSourceMediaType), TypeInfoPropertyName = "SmeMediaSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SMEMediaSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzePromptV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode), TypeInfoPropertyName = "CreateAsyncAnalyzeRequestAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncResponseFormatType), TypeInfoPropertyName = "AsyncResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldType), TypeInfoPropertyName = "SegmentFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldItemsType), TypeInfoPropertyName = "SegmentFieldItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentFieldItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.SegmentDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SegmentField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskWebhookInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseVideoSource, object>), TypeInfoPropertyName = "OneOfAnalyzeTaskResponseVideoSourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParams, object>), TypeInfoPropertyName = "OneOfAnalyzeTaskResponseRequestParamsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeAsyncTasksListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListAsyncAnalysisTasksRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeAsyncTasksDeleteResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateBulkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteAssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.TasksGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.Index>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.PresignedURLChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ChunkInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IncompleteUploadSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.CompletedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoIndexingTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.TranscriptionDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexedAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexedAssetSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoVector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EntityCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.TasksGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}