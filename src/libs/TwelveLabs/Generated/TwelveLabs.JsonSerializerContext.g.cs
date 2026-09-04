
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequestType), TypeInfoPropertyName = "CreateAssetUploadRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.PresignedURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailMethod), TypeInfoPropertyName = "AssetDetailMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailStatus), TypeInfoPropertyName = "AssetDetailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHlsStatus), TypeInfoPropertyName = "AssetHlsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHLS))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnailStatus), TypeInfoPropertyName = "AssetThumbnailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.VideoStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider), TypeInfoPropertyName = "ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DataConnectorsAuthorizeConnectionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AuthorizeConnectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionProvider), TypeInfoPropertyName = "ConnectionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionStatus), TypeInfoPropertyName = "ConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.Connection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RedirectUri))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRedirectUriRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRedirectUriRequestConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRedirectUriRequestUnprocessableEntityError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DataConnectorsListRedirectUrisResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.RedirectUri>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ListRedirectUrisRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteRedirectUriRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteRedirectUriRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportItemAction), TypeInfoPropertyName = "ImportItemAction2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreMetadataValue), TypeInfoPropertyName = "KnowledgeStoreMetadataValue2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName), TypeInfoPropertyName = "IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HlsObjectStatus), TypeInfoPropertyName = "HlsObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HLSObject))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksRetrieveResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RetrieveVideoIndexingTaskRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteVideoIndexingTaskRequestBadRequestError))]
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
        })]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentMetadataInputType), TypeInfoPropertyName = "AsyncDocumentMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems), TypeInfoPropertyName = "AsyncDocumentMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageMetadataInputType), TypeInfoPropertyName = "AsyncImageMetadataInputType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AuthorizeConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRedirectUriRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportFilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateBulkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.DeleteAssetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AddItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.RemoveItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.UpdateRequest7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateRequest12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.TasksGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.BatchStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod?), TypeInfoPropertyName = "NullableAssetsPostRequestBodyContentMultipartFormDataSchemaMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetMethod?), TypeInfoPropertyName = "NullableAssetMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetStatus?), TypeInfoPropertyName = "NullableAssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceType?), TypeInfoPropertyName = "NullableAssetSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetSourceDetailsProvider?), TypeInfoPropertyName = "NullableAssetSourceDetailsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAssetUploadRequestType?), TypeInfoPropertyName = "NullableCreateAssetUploadRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.MultipartUploadStatusType?), TypeInfoPropertyName = "NullableMultipartUploadStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ChunkInfoStatus?), TypeInfoPropertyName = "NullableChunkInfoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CompletedChunkProofType?), TypeInfoPropertyName = "NullableCompletedChunkProofType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailMethod?), TypeInfoPropertyName = "NullableAssetDetailMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetDetailStatus?), TypeInfoPropertyName = "NullableAssetDetailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetHlsStatus?), TypeInfoPropertyName = "NullableAssetHlsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetThumbnailStatus?), TypeInfoPropertyName = "NullableAssetThumbnailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems?), TypeInfoPropertyName = "NullableAssetsGetParametersAssetTypesSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems?), TypeInfoPropertyName = "NullableAssetsAssetIdTranscriptionGetParametersIncludeSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AssetTranscriptionStatus?), TypeInfoPropertyName = "NullableAssetTranscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider?), TypeInfoPropertyName = "NullableConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionProvider?), TypeInfoPropertyName = "NullableConnectionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ConnectionStatus?), TypeInfoPropertyName = "NullableConnectionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.ImportItemAction?), TypeInfoPropertyName = "NullableImportItemAction2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.KnowledgeStoreMetadataValue?), TypeInfoPropertyName = "NullableKnowledgeStoreMetadataValue2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName?), TypeInfoPropertyName = "NullableIndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems?), TypeInfoPropertyName = "NullableIndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetDetailedStatus?), TypeInfoPropertyName = "NullableIndexedAssetDetailedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.HlsObjectStatus?), TypeInfoPropertyName = "NullableHlsObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems?), TypeInfoPropertyName = "NullableIndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema?), TypeInfoPropertyName = "NullableIndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexedAssetStatus?), TypeInfoPropertyName = "NullableIndexedAssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema?), TypeInfoPropertyName = "NullableIndexesIndexIdVideosGetParametersUserMetadataSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems?), TypeInfoPropertyName = "NullableIndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.TasksGetParametersStatusSchemaItems?), TypeInfoPropertyName = "NullableTasksGetParametersStatusSchemaItems2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentMetadataInputType?), TypeInfoPropertyName = "NullableAsyncDocumentMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems?), TypeInfoPropertyName = "NullableAsyncDocumentMetadataEmbeddingScopesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageMetadataInputType?), TypeInfoPropertyName = "NullableAsyncImageMetadataInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems?), TypeInfoPropertyName = "NullableAsyncImageMetadataEmbeddingScopesItems2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode?), TypeInfoPropertyName = "NullableAnalyzeTaskResponseRequestParamsAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType?), TypeInfoPropertyName = "NullableAnalyzeTaskResponseRequestParamsResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeBatchRequestModelName?), TypeInfoPropertyName = "NullableCreateAnalyzeBatchRequestModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode?), TypeInfoPropertyName = "NullableCreateAnalyzeBatchRequestAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchVideoContextType?), TypeInfoPropertyName = "NullableBatchVideoContextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchStatus?), TypeInfoPropertyName = "NullableBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems?), TypeInfoPropertyName = "NullableAnalyzeBatchesGetParametersAnalysisModeSchemaItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode?), TypeInfoPropertyName = "NullableAnalyzeBatchStatusResponseAnalysisMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TwelveLabs.BatchItemStatus?), TypeInfoPropertyName = "NullableBatchItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.PresignedURLChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ChunkInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IncompleteUploadSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.CompletedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AudioStream>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetTranscriptionEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetTranscriptionUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.Connection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.RedirectUri>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.ResponseAnnotation>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.VideoIndexingTask>))]
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
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.TasksGetParametersStatusSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.BatchStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


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

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreMetadataValueJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TextParamFormatJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.ResponseStreamEventJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.IndexesIndexIdVideosGetParametersUserMetadataSchemaJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoSegmentationJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.TemporalSegmentationJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AsyncAudioInputRequestSegmentationJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AsyncVideoInputRequestSegmentationJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.VideoContextJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.StreamAnalyzeResponseJsonConverter());
            options.Converters.Add(new global::TwelveLabs.JsonConverters.AnalyzeResponse200JsonConverter());
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

                    || typeToConvert == typeof(global::TwelveLabs.CreateAssetUploadRequestType)

                    || typeToConvert == typeof(global::TwelveLabs.CreateAssetUploadRequestType?)

                    || typeToConvert == typeof(global::TwelveLabs.MultipartUploadStatusType)

                    || typeToConvert == typeof(global::TwelveLabs.MultipartUploadStatusType?)

                    || typeToConvert == typeof(global::TwelveLabs.ChunkInfoStatus)

                    || typeToConvert == typeof(global::TwelveLabs.ChunkInfoStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.CompletedChunkProofType)

                    || typeToConvert == typeof(global::TwelveLabs.CompletedChunkProofType?)

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

                    || typeToConvert == typeof(global::TwelveLabs.AssetTranscriptionStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider)

                    || typeToConvert == typeof(global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider?)

                    || typeToConvert == typeof(global::TwelveLabs.ConnectionProvider)

                    || typeToConvert == typeof(global::TwelveLabs.ConnectionProvider?)

                    || typeToConvert == typeof(global::TwelveLabs.ConnectionStatus)

                    || typeToConvert == typeof(global::TwelveLabs.ConnectionStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.ImportItemAction)

                    || typeToConvert == typeof(global::TwelveLabs.ImportItemAction?)

                    || typeToConvert == typeof(global::TwelveLabs.ImportItemStatus)

                    || typeToConvert == typeof(global::TwelveLabs.ImportItemStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.ImportProvider)

                    || typeToConvert == typeof(global::TwelveLabs.ImportProvider?)

                    || typeToConvert == typeof(global::TwelveLabs.ImportDetailProvider)

                    || typeToConvert == typeof(global::TwelveLabs.ImportDetailProvider?)

                    || typeToConvert == typeof(global::TwelveLabs.EntityCollectionsGetParametersSortBy)

                    || typeToConvert == typeof(global::TwelveLabs.EntityCollectionsGetParametersSortBy?)

                    || typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus)

                    || typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy)

                    || typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy?)

                    || typeToConvert == typeof(global::TwelveLabs.EntityStatus)

                    || typeToConvert == typeof(global::TwelveLabs.EntityStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType?)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType?)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDescriptionType)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDescriptionType?)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType)

                    || typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSearchModality)

                    || typeToConvert == typeof(global::TwelveLabs.VideoSearchModality?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemStatus)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoMetadataAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.VideoMetadataAssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.ImageMetadataAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.ImageMetadataAssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy)

                    || typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy?)

                    || typeToConvert == typeof(global::TwelveLabs.ResponseInputItemType)

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

                    || typeToConvert == typeof(global::TwelveLabs.ResponseStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName?)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.IndexedAssetDetailedStatus)

                    || typeToConvert == typeof(global::TwelveLabs.IndexedAssetDetailedStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.HlsObjectStatus)

                    || typeToConvert == typeof(global::TwelveLabs.HlsObjectStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.IndexedAssetStatus)

                    || typeToConvert == typeof(global::TwelveLabs.IndexedAssetStatus?)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.TasksGetParametersStatusSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.TasksGetParametersStatusSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy?)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator)

                    || typeToConvert == typeof(global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator?)

                    || typeToConvert == typeof(global::TwelveLabs.CreateEmbeddingsRequestInputType)

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

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingImageMetadataInputType)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingImageMetadataInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingTextImageMetadataInputType)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingTextImageMetadataInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataInputType)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataInputType)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingMultiInputMetadataInputType)

                    || typeToConvert == typeof(global::TwelveLabs.EmbeddingMultiInputMetadataInputType?)

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

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataInputType)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataInputType)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataInputType?)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems)

                    || typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems)

                    || typeToConvert == typeof(global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems?)

                    || typeToConvert == typeof(global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems)

                    || typeToConvert == typeof(global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems?)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName)

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant1Type)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant1Type?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant2Type)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant2Type?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant3Type)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextVariant3Type?)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextDiscriminatorType)

                    || typeToConvert == typeof(global::TwelveLabs.VideoContextDiscriminatorType?)

                    || typeToConvert == typeof(global::TwelveLabs.SmeMediaSourceMediaType)

                    || typeToConvert == typeof(global::TwelveLabs.SmeMediaSourceMediaType?)

                    || typeToConvert == typeof(global::TwelveLabs.SyncResponseFormatType)

                    || typeToConvert == typeof(global::TwelveLabs.SyncResponseFormatType?)

                    || typeToConvert == typeof(global::TwelveLabs.StreamStartResponseEventType)

                    || typeToConvert == typeof(global::TwelveLabs.StreamStartResponseEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.StreamTextResponseEventType)

                    || typeToConvert == typeof(global::TwelveLabs.StreamTextResponseEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.StreamEndResponseEventType)

                    || typeToConvert == typeof(global::TwelveLabs.StreamEndResponseEventType?)

                    || typeToConvert == typeof(global::TwelveLabs.FinishReason)

                    || typeToConvert == typeof(global::TwelveLabs.FinishReason?)

                    || typeToConvert == typeof(global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType)

                    || typeToConvert == typeof(global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType?)

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

                    || typeToConvert == typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType?)

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

                if (typeToConvert == typeof(global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider))
                {
                    return new global::TwelveLabs.JsonConverters.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider?))
                {
                    return new global::TwelveLabs.JsonConverters.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ConnectionProvider))
                {
                    return new global::TwelveLabs.JsonConverters.ConnectionProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ConnectionProvider?))
                {
                    return new global::TwelveLabs.JsonConverters.ConnectionProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ConnectionStatus))
                {
                    return new global::TwelveLabs.JsonConverters.ConnectionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ConnectionStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.ConnectionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImportItemAction))
                {
                    return new global::TwelveLabs.JsonConverters.ImportItemActionJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImportItemAction?))
                {
                    return new global::TwelveLabs.JsonConverters.ImportItemActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImportItemStatus))
                {
                    return new global::TwelveLabs.JsonConverters.ImportItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImportItemStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.ImportItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImportProvider))
                {
                    return new global::TwelveLabs.JsonConverters.ImportProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImportProvider?))
                {
                    return new global::TwelveLabs.JsonConverters.ImportProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImportDetailProvider))
                {
                    return new global::TwelveLabs.JsonConverters.ImportDetailProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImportDetailProvider?))
                {
                    return new global::TwelveLabs.JsonConverters.ImportDetailProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityCollectionsGetParametersSortBy))
                {
                    return new global::TwelveLabs.JsonConverters.EntityCollectionsGetParametersSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityCollectionsGetParametersSortBy?))
                {
                    return new global::TwelveLabs.JsonConverters.EntityCollectionsGetParametersSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus))
                {
                    return new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy))
                {
                    return new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy?))
                {
                    return new global::TwelveLabs.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityStatus))
                {
                    return new global::TwelveLabs.JsonConverters.EntityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EntityStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.EntityStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaType?))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType?))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDescriptionType))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDescriptionType?))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EnrichmentConfigDiscriminatorType?))
                {
                    return new global::TwelveLabs.JsonConverters.EnrichmentConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresGetParametersSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresGetParametersSortBy?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresGetParametersSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoSearchModality))
                {
                    return new global::TwelveLabs.JsonConverters.VideoSearchModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoSearchModality?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoSearchModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemStatus))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoMetadataAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.VideoMetadataAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImageMetadataAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.ImageMetadataAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy?))
                {
                    return new global::TwelveLabs.JsonConverters.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortByNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName?))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexedAssetDetailedStatus))
                {
                    return new global::TwelveLabs.JsonConverters.IndexedAssetDetailedStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexedAssetDetailedStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.IndexedAssetDetailedStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.HlsObjectStatus))
                {
                    return new global::TwelveLabs.JsonConverters.HlsObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.HlsObjectStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.HlsObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexedAssetStatus))
                {
                    return new global::TwelveLabs.JsonConverters.IndexedAssetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexedAssetStatus?))
                {
                    return new global::TwelveLabs.JsonConverters.IndexedAssetStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TasksGetParametersStatusSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.TasksGetParametersStatusSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.TasksGetParametersStatusSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.TasksGetParametersStatusSchemaItemsNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingImageMetadataInputType))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingImageMetadataInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingImageMetadataInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingImageMetadataInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingMediaMetadataInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingTextImageMetadataInputType))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingTextImageMetadataInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingTextImageMetadataInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingTextImageMetadataInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataInputType))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataInputType))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingMultiInputMetadataInputType))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingMultiInputMetadataInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbeddingMultiInputMetadataInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbeddingMultiInputMetadataInputTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataInputType))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentMetadataInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentMetadataInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentMetadataEmbeddingScopesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncDocumentMetadataEmbeddingScopesItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataInputType))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageMetadataInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataInputType?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageMetadataInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageMetadataEmbeddingScopesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems?))
                {
                    return new global::TwelveLabs.JsonConverters.AsyncImageMetadataEmbeddingScopesItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems))
                {
                    return new global::TwelveLabs.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems))
                {
                    return new global::TwelveLabs.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems?))
                {
                    return new global::TwelveLabs.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzePostRequestBodyContentApplicationJsonSchemaModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName?))
                {
                    return new global::TwelveLabs.JsonConverters.AnalyzePostRequestBodyContentApplicationJsonSchemaModelNameNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::TwelveLabs.SyncResponseFormatType))
                {
                    return new global::TwelveLabs.JsonConverters.SyncResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.SyncResponseFormatType?))
                {
                    return new global::TwelveLabs.JsonConverters.SyncResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.StreamStartResponseEventType))
                {
                    return new global::TwelveLabs.JsonConverters.StreamStartResponseEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.StreamStartResponseEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.StreamStartResponseEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.StreamTextResponseEventType))
                {
                    return new global::TwelveLabs.JsonConverters.StreamTextResponseEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.StreamTextResponseEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.StreamTextResponseEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.StreamEndResponseEventType))
                {
                    return new global::TwelveLabs.JsonConverters.StreamEndResponseEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.StreamEndResponseEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.StreamEndResponseEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.FinishReason))
                {
                    return new global::TwelveLabs.JsonConverters.FinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.FinishReason?))
                {
                    return new global::TwelveLabs.JsonConverters.FinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType))
                {
                    return new global::TwelveLabs.JsonConverters.StreamAnalyzeResponseDiscriminatorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType?))
                {
                    return new global::TwelveLabs.JsonConverters.StreamAnalyzeResponseDiscriminatorEventTypeNullableJsonConverter();
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}