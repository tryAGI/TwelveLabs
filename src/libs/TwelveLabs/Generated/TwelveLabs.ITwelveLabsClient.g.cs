
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ITwelveLabsClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::TwelveLabs.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AnalyzeAsyncBatchesClient AnalyzeAsyncBatches { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnalyzeAsyncTasksClient AnalyzeAsyncTasks { get; }

        /// <summary>
        /// 
        /// </summary>
        public AssetsClient Assets { get; }

        /// <summary>
        /// 
        /// </summary>
        public DataConnectorsClient DataConnectors { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmbedClient Embed { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmbedTasksClient EmbedTasks { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmbedV2Client EmbedV2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmbedV2TasksClient EmbedV2Tasks { get; }

        /// <summary>
        /// 
        /// </summary>
        public EntityCollectionsClient EntityCollections { get; }

        /// <summary>
        /// 
        /// </summary>
        public EntityCollectionsEntitiesClient EntityCollectionsEntities { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImportsClient Imports { get; }

        /// <summary>
        /// 
        /// </summary>
        public IndexesClient Indexes { get; }

        /// <summary>
        /// 
        /// </summary>
        public IndexesIndexedAssetsClient IndexesIndexedAssets { get; }

        /// <summary>
        /// 
        /// </summary>
        public IndexesVideosClient IndexesVideos { get; }

        /// <summary>
        /// 
        /// </summary>
        public KnowledgeStoreItemCollectionsClient KnowledgeStoreItemCollections { get; }

        /// <summary>
        /// 
        /// </summary>
        public KnowledgeStoreItemsClient KnowledgeStoreItems { get; }

        /// <summary>
        /// 
        /// </summary>
        public KnowledgeStoresClient KnowledgeStores { get; }

        /// <summary>
        /// 
        /// </summary>
        public MultipartUploadClient MultipartUpload { get; }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClient Responses { get; }

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// 
        /// </summary>
        public TasksClient Tasks { get; }

    }
}