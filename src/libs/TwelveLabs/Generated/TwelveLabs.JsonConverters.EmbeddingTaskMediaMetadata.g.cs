#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingTaskMediaMetadataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.EmbeddingTaskMediaMetadata>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.EmbeddingTaskMediaMetadata Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("duration")) __score0++;
            if (__jsonProps.Contains("embedding_options")) __score0++;
            if (__jsonProps.Contains("embedding_scopes")) __score0++;
            if (__jsonProps.Contains("end_offset_sec")) __score0++;
            if (__jsonProps.Contains("input_filename")) __score0++;
            if (__jsonProps.Contains("input_type")) __score0++;
            if (__jsonProps.Contains("input_url")) __score0++;
            if (__jsonProps.Contains("start_offset_sec")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("clip_length")) __score1++;
            if (__jsonProps.Contains("duration")) __score1++;
            if (__jsonProps.Contains("embedding_options")) __score1++;
            if (__jsonProps.Contains("embedding_scopes")) __score1++;
            if (__jsonProps.Contains("end_offset_sec")) __score1++;
            if (__jsonProps.Contains("input_filename")) __score1++;
            if (__jsonProps.Contains("input_type")) __score1++;
            if (__jsonProps.Contains("input_url")) __score1++;
            if (__jsonProps.Contains("start_offset_sec")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("embedding_options")) __score2++;
            if (__jsonProps.Contains("embedding_scopes")) __score2++;
            if (__jsonProps.Contains("input_filename")) __score2++;
            if (__jsonProps.Contains("input_type")) __score2++;
            if (__jsonProps.Contains("input_url")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("embedding_options")) __score3++;
            if (__jsonProps.Contains("embedding_scopes")) __score3++;
            if (__jsonProps.Contains("input_filename")) __score3++;
            if (__jsonProps.Contains("input_type")) __score3++;
            if (__jsonProps.Contains("input_url")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? embeddingTaskMediaMetadataVariant1 = default;
            global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? embeddingTaskMediaMetadataVariant2 = default;
            global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? embeddingTaskMediaMetadataVariant3 = default;
            global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? embeddingTaskMediaMetadataVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1).Name}");
                        embeddingTaskMediaMetadataVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2).Name}");
                        embeddingTaskMediaMetadataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3).Name}");
                        embeddingTaskMediaMetadataVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4).Name}");
                        embeddingTaskMediaMetadataVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (embeddingTaskMediaMetadataVariant1 == null && embeddingTaskMediaMetadataVariant2 == null && embeddingTaskMediaMetadataVariant3 == null && embeddingTaskMediaMetadataVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1).Name}");
                    embeddingTaskMediaMetadataVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingTaskMediaMetadataVariant1 == null && embeddingTaskMediaMetadataVariant2 == null && embeddingTaskMediaMetadataVariant3 == null && embeddingTaskMediaMetadataVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2).Name}");
                    embeddingTaskMediaMetadataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingTaskMediaMetadataVariant1 == null && embeddingTaskMediaMetadataVariant2 == null && embeddingTaskMediaMetadataVariant3 == null && embeddingTaskMediaMetadataVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3).Name}");
                    embeddingTaskMediaMetadataVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingTaskMediaMetadataVariant1 == null && embeddingTaskMediaMetadataVariant2 == null && embeddingTaskMediaMetadataVariant3 == null && embeddingTaskMediaMetadataVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4).Name}");
                    embeddingTaskMediaMetadataVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::TwelveLabs.EmbeddingTaskMediaMetadata(
                embeddingTaskMediaMetadataVariant1,

                embeddingTaskMediaMetadataVariant2,

                embeddingTaskMediaMetadataVariant3,

                embeddingTaskMediaMetadataVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.EmbeddingTaskMediaMetadata value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEmbeddingTaskMediaMetadataVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingTaskMediaMetadataVariant1!, typeInfo);
            }
            else if (value.IsEmbeddingTaskMediaMetadataVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingTaskMediaMetadataVariant2!, typeInfo);
            }
            else if (value.IsEmbeddingTaskMediaMetadataVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingTaskMediaMetadataVariant3!, typeInfo);
            }
            else if (value.IsEmbeddingTaskMediaMetadataVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingTaskMediaMetadataVariant4!, typeInfo);
            }
        }
    }
}