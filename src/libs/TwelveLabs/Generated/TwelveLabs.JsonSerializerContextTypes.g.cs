
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetMethod? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetStatus? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UserMetadataValue? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.UserMetadataValue>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSourceType? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSourceDetailsProvider? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSourceDetails? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSource? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Asset? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetRequestBadRequestError? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadRequestType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadRequest? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PresignedURLChunk? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadResponse? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.PresignedURLChunk>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestBadRequestError? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestForbiddenError? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestInternalServerError? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultipartUploadStatusType? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ChunkInfoStatus? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ChunkInfo? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PageInfo? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusResponse? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ChunkInfo>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestBadRequestError? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestForbiddenError? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestInternalServerError? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IncompleteUploadSummary? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsResponse? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IncompleteUploadSummary>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestBadRequestError? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestForbiddenError? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestInternalServerError? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CompletedChunkProofType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CompletedChunk? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.CompletedChunk>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchResponse? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequestBadRequestError? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequestForbiddenError? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedURLsRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedURLsResponse? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestBadRequestError? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestForbiddenError? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestInternalServerError? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetailMethod? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetailStatus? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetHlsStatus? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetHLS? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetThumbnailStatus? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetThumbnail? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoStream? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioStream? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TechnicalMetadata? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoStream>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioStream>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetError? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetail? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetRequestBadRequestError? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetRequestNotFoundError? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsListResponse200? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetDetail>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAssetsRequestBadRequestError? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetRequestBadRequestError? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetRequestConflictError? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateAssetUserMetadataRequestBadRequestError? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateAssetUserMetadataRequestNotFoundError? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceAssetUserMetadataRequestBadRequestError? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceAssetUserMetadataRequestNotFoundError? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetUserMetadataRequestBadRequestError? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetUserMetadataRequestNotFoundError? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionStatus? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionEntry? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionUtterance? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionError? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionEntry>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionUtterance>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetTranscriptionRequestBadRequestError? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetTranscriptionRequestNotFoundError? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsAuthorizeConnectionResponse200? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AuthorizeConnectionRequestBadRequestError? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionProvider? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionStatus? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionAccount? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Connection? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsListConnectionsResponse200? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Connection>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListConnectionsRequestBadRequestError? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveConnectionRequestBadRequestError? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveConnectionRequestNotFoundError? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteConnectionRequestBadRequestError? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteConnectionRequestNotFoundError? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsCreateConnectionPickerTokenResponse200? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestBadRequestError? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestNotFoundError? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestConflictError? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RedirectUri? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestBadRequestError? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestConflictError? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestUnprocessableEntityError? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsListRedirectUrisResponse200? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.RedirectUri>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListRedirectUrisRequestBadRequestError? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteRedirectUriRequestBadRequestError? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteRedirectUriRequestNotFoundError? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemAction? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemStatus? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemError? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItem? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportResult? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ImportItem>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestBadRequestError? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestNotFoundError? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestConflictError? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportProvider? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Import? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportsListImportsResponse200? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Import>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListImportsRequestBadRequestError? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListImportsRequestNotFoundError? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportDetailProvider? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportDetail? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveImportRequestBadRequestError? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveImportRequestNotFoundError? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsGetParametersSortBy? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollection? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsListResponse200? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollection>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntityCollectionsRequestBadRequestError? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntityCollectionRequestBadRequestError? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveEntityCollectionRequestBadRequestError? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateEntityCollectionRequestBadRequestError? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteEntityCollectionRequestBadRequestError? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityMetadata? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityStatus? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Entity? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntitiesListResponse200? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Entity>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntitiesInCollectionRequestBadRequestError? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntityRequestBadRequestError? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItemsMetadata? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponseEntitiesItems? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponseErrorsItems? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntitiesBulkRequestBadRequestError? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveEntityRequestBadRequestError? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesEntityIdPatchRequestBodyContentApplicationJsonSchemaMetadata? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateEntityRequestBadRequestError? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteEntityRequestBadRequestError? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddEntityAssetsRequestBadRequestError? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveEntityAssetsRequestBadRequestError? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntitiesListByAssetResponse200? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntitiesByAssetRequestBadRequestError? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchema? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDescriptionType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfig? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigVariant1? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigVariant2? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDiscriminator? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDiscriminatorType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IngestionConfig? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreMetadataValue? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStore? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreRequestBadRequestError? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresGetParametersSortBy? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresListResponse200? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStore>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoresRequestBadRequestError? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreRequestBadRequestError? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreRequestBadRequestError? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreRequestBadRequestError? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreSearchQuery? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemAssetType? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTypeFilter? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemAssetType>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ItemIdFilter? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreFilter? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchModality? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchOptions? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreOptions? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchSystemMetadata? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchItemMetadata? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoMatch? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageSearchSystemMetadata? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageSearchItemMetadata? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHit? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoMatch>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminator? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreResponse? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchKnowledgeStoreHit>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestGoneError? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemStatus? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoMetadataAssetType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageMetadataAssetType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadata? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminator? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItem? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemRequestBadRequestError? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemsListResponse200? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItem>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemsRequestBadRequestError? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemRequestBadRequestError? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemRequestBadRequestError? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollection? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemCollectionRequestBadRequestError? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollectionsListResponse200? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemCollection>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemCollectionsRequestBadRequestError? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemCollectionRequestBadRequestError? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemCollectionRequestBadRequestError? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemCollectionRequestBadRequestError? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollectionsListItemsResponse200? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemCollectionItemsRequestBadRequestError? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddItemsToKnowledgeStoreItemCollectionRequestBadRequestError? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveItemsFromKnowledgeStoreItemCollectionRequestBadRequestError? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItemType? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItemRole? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItem? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseSelectionKind? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseSelection? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextResponseFormatTextType? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextResponseFormatJsonSchemaType? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormat? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant1? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant2? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminator? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminatorType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParam? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObjectType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObjectObject? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStatus? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseIncompleteDetails? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemRole? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputContentPartType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseAnnotationType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseAnnotation? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputContentPart? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseAnnotation>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItem? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputContentPart>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseUsage? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObject? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputItem>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateResponseRequestBadRequestError? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamResponseEventType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputItemAddedEventType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamContentPartAddedEventType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputTextDeltaEventType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputTextDoneEventType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamContentPartDoneEventType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputItemDoneEventType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamKeepAliveEventType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEvent? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant1? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant2? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant3? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant4? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant5? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant6? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant7? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant8? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant9? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant10? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant11? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant12? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventDiscriminator? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventDiscriminatorType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesCreateResponse201? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexRequestBadRequestError? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexModelsItems? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Index? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexModelsItems>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesListResponse200? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Index>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexesRequestBadRequestError? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexRequestBadRequestError? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateIndexRequestBadRequestError? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteIndexRequestBadRequestError? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsCreateResponse202? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestBadRequestError? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestNotFoundError? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestInternalServerError? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedStatus? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedSystemMetadata? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.HlsObjectStatus? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.HLSObject? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegment? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedEmbeddingVideoEmbedding? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSegment>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedEmbedding? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TranscriptionDataItems? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TranscriptionDataItems>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailed? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexedAssetInformationRequestBadRequestError? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexedAssetInformationRequestNotFoundError? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersDuration? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersFps? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersWidth? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersHeight? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersSize? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetStatus? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSystemMetadata? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAsset? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsListResponse200? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAsset>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexedAssetsRequestBadRequestError? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteIndexedAssetInformationRequestBadRequestError? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PartialUpdateIndexedAssetInformationRequestBadRequestError? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSummaryIndex? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSummary? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsListByAssetResponse200? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAssetSummary>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexedAssetsByAssetRequestBadRequestError? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersDuration? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersFps? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersWidth? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersHeight? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersSize? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoVectorSystemMetadata? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoVector? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesVideosListResponse200? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoVector>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideosRequestBadRequestError? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbeddingVideoEmbedding? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesVideosRetrieveResponse200? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoInformationRequestBadRequestError? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoInformationRequestNotFoundError? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PartialUpdateVideoInformationRequestBadRequestError? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteVideoInformationRequestBadRequestError? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksCreateResponse200? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateVideoIndexingTaskRequestBadRequestError? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksGetParametersStatusSchemaItems? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoIndexingTaskSystemMetadata? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoIndexingTask? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksGetResponsesContentApplicationJsonSchemaPageInfo? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksListResponse200? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoIndexingTask>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideoIndexingTasksRequestBadRequestError? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksTaskIdGetResponsesContentApplicationJsonSchemaSystemMetadata? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksRetrieveResponse200? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoIndexingTaskRequestBadRequestError? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteVideoIndexingTaskRequestBadRequestError? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchItemClipsItems? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchItem? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchItemClipsItems>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchResultsPageInfo? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPool? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchResults? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchItem>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnyToVideoSearchRequestBadRequestError? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchRetrieveResponse200? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnyToVideoRetrieveSpecificPageRequestBadRequestError? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestInputType? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestModelName? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestEmbeddingDimension? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextInputRequest? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaSource? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageInputRequest? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextImageInputRequest? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentationFixed? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentation? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentationStrategy? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingOptionItems? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingScopeItems? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingTypeItems? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequest? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingOptionItems>? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingScopeItems>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorMappingDynamicDynamic? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorMappingFixedFixed? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentation? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1Strategy? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2Strategy? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminator? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorStrategy? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingOptionItems? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingScopeItems? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingTypeItems? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequest? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingOptionItems>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingScopeItems>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingTypeItems>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputMediaSourceMediaType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputMediaSource? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputRequest? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MultiInputMediaSource>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequest? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataEmbeddingOption? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataEmbeddingScope? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataQuadrant? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingData? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingUsageTruncationReason? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingUsage? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingImageMetadataInputType? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataInputType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTextImageMetadataInputType? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingAudioMetadataInputType? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingVideoMetadataInputType? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMultiInputMetadataInputType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadata? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant1? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant2? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant3? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant4? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant5? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataDiscriminator? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingSuccessResponse? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ErrorResponseError? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ErrorResponse? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestInputType? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestModelName? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingDynamicDynamic? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingFixedFixed? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentation? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1Strategy? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2Strategy? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminator? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncTemporalSegmentation? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestSegmentation? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeBasedMetadataEntry? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequest? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeBasedMetadataEntry>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestSegmentation? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequest? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSpatialSegmentationStrategy? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSpatialSegmentation? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSequentialSegmentationStrategy? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSequentialSegmentation? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSegmentation? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequest? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequest? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequest? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksCreateResponse202? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoEmbeddingMetadata? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskVideoEmbedding? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioEmbeddingMetadata? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskAudioEmbedding? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentEmbeddingMetadata? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskDocumentEmbedding? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageEmbeddingMetadata? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskImageEmbedding? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTask? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksListResponse200? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MediaEmbeddingTask>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAsyncEmbeddingTasksRequestBadRequestError? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponseStatus? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataInputType? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentMetadataInputType? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageMetadataInputType? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadata? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataDiscriminator? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponseError? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponse? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksCreateResponse200? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateVideoEmbeddingTaskRequestBadRequestError? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksGetResponsesContentApplicationJsonSchemaPageInfo? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksListResponse200? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideoEmbeddingTasksRequestBadRequestError? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdStatusGetResponsesContentApplicationJsonSchemaVideoEmbedding? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksStatusResponse200? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoEmbeddingTaskRequestBadRequestError? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksRetrieveResponse200? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoEmbeddingRequestBadRequestError? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BaseSegment? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextEmbeddingResult? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BaseSegment>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BaseEmbeddingMetadata? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageEmbeddingResult? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegment? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioEmbeddingResult? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioSegment>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingResponse? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateTextImageAudioEmbeddingRequestBadRequestError? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContext? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1Type? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2Type? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3Type? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminator? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminatorType? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeImageInput? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SmeMediaSourceMediaType? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SMEMediaSource? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzePromptV2? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormatType? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormatJsonSchema? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormat? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamStartResponseEventType? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamStartResponseMetadata? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamTextResponseEventType? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamEndResponseEventType? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.FinishReason? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TokenUsage? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamEndResponseMetadata? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskError? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponse? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant1? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant2? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant3? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminator? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.NonStreamAnalyzeResponse? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeResponse200? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GenerateTextRepresentationRequestNotFoundError? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestModelName? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatType? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatJsonSchema? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldType? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldFormat? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldItemsType? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldType? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldItemsType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldItems? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemField? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldItems? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeArrayItemField>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentField? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTimeRange? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentDefinition? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentField>? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormat? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentDefinition>? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequest? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeImageInput>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskStatus? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeTaskResponse? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceType? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSource? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskMediaSource? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskMediaSource>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentFieldFormat? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskTimeArrayItemFieldItems? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskTimeArrayItemField? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentFieldItems? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskTimeArrayItemField>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentField? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskSegmentField>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParams? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResultUsage? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResult? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskWebhookInfo? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponse? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeAsyncTasksListResponse200? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponse>? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAsyncAnalysisTasksRequestBadRequestError? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CancelAnalyzeTaskResponseStatus? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CancelAnalyzeTaskResponse? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.FlatErrorResponse? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequestModelName? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchPrompt? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchDefaults? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchVideoContextType? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchVideoContext? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemRequest? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequest? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BatchItemRequest>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchStatus? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreatedBatchItem? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchResponse? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.CreatedBatchItem>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchStatusResponse? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeAsyncBatchesListResponse200? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchStatusResponse>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemStatus? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemError? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchResultItem? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateUserMetadataRequest? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceUserMetadataRequest? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AuthorizeConnectionRequest? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequest? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequest? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest2? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest3? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateBulkRequest? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest2? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetsRequest? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetsRequest? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest4? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest3? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest5? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest6? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest4? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddItemsRequest? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveItemsRequest? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateStreamRequest? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem>? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest7? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest5? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest8? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest6? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest7? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest9? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest10? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest11? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest12? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeRequest? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema>? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TasksGetParametersStatusSchemaItems>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BatchStatus>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>? Type757 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.PresignedURLChunk>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ChunkInfo>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IncompleteUploadSummary>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.CompletedChunk>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoStream>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioStream>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetDetail>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetTranscriptionEntry>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetTranscriptionUtterance>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.Connection>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.RedirectUri>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ImportItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.Import>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EntityCollection>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.Entity>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStore>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItemAssetType>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoSearchModality>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoMatch>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchKnowledgeStoreHit>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItemCollection>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseAnnotation>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseOutputContentPart>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseOutputItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexModelsItems>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.Index>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoSegment>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TranscriptionDataItems>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexedAsset>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexedAssetSummary>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoVector>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoIndexingTask>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchItemClipsItems>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchItem>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingOptionItems>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingScopeItems>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingOptionItems>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingScopeItems>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingTypeItems>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.MultiInputMediaSource>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingData>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TimeBasedMetadataEntry>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.MediaEmbeddingTask>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BaseSegment>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioSegment>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SMEMediaSource>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TimeArrayItemField>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SegmentField>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTimeRange>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SegmentDefinition>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeImageInput>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskMediaSource>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskTimeArrayItemField>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskSegmentField>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskWebhookInfo>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponse>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BatchItemRequest>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.CreatedBatchItem>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchStatusResponse>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseInputItem>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseSelection>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TasksGetParametersStatusSchemaItems>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BatchStatus>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>? ListType101 { get; set; }
    }
}