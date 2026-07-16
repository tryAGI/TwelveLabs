#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingMediaMetadataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.EmbeddingMediaMetadata>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.EmbeddingMediaMetadata Read(
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
            if (__jsonProps.Contains("input_filename")) __score0++;
            if (__jsonProps.Contains("input_type")) __score0++;
            if (__jsonProps.Contains("input_url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("input_filename")) __score1++;
            if (__jsonProps.Contains("input_type")) __score1++;
            if (__jsonProps.Contains("input_url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("duration")) __score2++;
            if (__jsonProps.Contains("embedding_options")) __score2++;
            if (__jsonProps.Contains("embedding_scopes")) __score2++;
            if (__jsonProps.Contains("end_offset_sec")) __score2++;
            if (__jsonProps.Contains("input_filename")) __score2++;
            if (__jsonProps.Contains("input_type")) __score2++;
            if (__jsonProps.Contains("input_url")) __score2++;
            if (__jsonProps.Contains("start_offset_sec")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("clip_length")) __score3++;
            if (__jsonProps.Contains("duration")) __score3++;
            if (__jsonProps.Contains("embedding_options")) __score3++;
            if (__jsonProps.Contains("embedding_scopes")) __score3++;
            if (__jsonProps.Contains("end_offset_sec")) __score3++;
            if (__jsonProps.Contains("input_filename")) __score3++;
            if (__jsonProps.Contains("input_type")) __score3++;
            if (__jsonProps.Contains("input_url")) __score3++;
            if (__jsonProps.Contains("start_offset_sec")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("input_type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::TwelveLabs.EmbeddingMediaMetadataVariant1? embeddingMediaMetadataVariant1 = default;
            global::TwelveLabs.EmbeddingMediaMetadataVariant2? embeddingMediaMetadataVariant2 = default;
            global::TwelveLabs.EmbeddingMediaMetadataVariant3? embeddingMediaMetadataVariant3 = default;
            global::TwelveLabs.EmbeddingMediaMetadataVariant4? embeddingMediaMetadataVariant4 = default;
            global::TwelveLabs.EmbeddingMediaMetadataVariant5? embeddingMediaMetadataVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant1).Name}");
                        embeddingMediaMetadataVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant2).Name}");
                        embeddingMediaMetadataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant3).Name}");
                        embeddingMediaMetadataVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant4).Name}");
                        embeddingMediaMetadataVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant5).Name}");
                        embeddingMediaMetadataVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (embeddingMediaMetadataVariant1 == null && embeddingMediaMetadataVariant2 == null && embeddingMediaMetadataVariant3 == null && embeddingMediaMetadataVariant4 == null && embeddingMediaMetadataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant1).Name}");
                    embeddingMediaMetadataVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingMediaMetadataVariant1 == null && embeddingMediaMetadataVariant2 == null && embeddingMediaMetadataVariant3 == null && embeddingMediaMetadataVariant4 == null && embeddingMediaMetadataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant2).Name}");
                    embeddingMediaMetadataVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingMediaMetadataVariant1 == null && embeddingMediaMetadataVariant2 == null && embeddingMediaMetadataVariant3 == null && embeddingMediaMetadataVariant4 == null && embeddingMediaMetadataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant3).Name}");
                    embeddingMediaMetadataVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingMediaMetadataVariant1 == null && embeddingMediaMetadataVariant2 == null && embeddingMediaMetadataVariant3 == null && embeddingMediaMetadataVariant4 == null && embeddingMediaMetadataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant4).Name}");
                    embeddingMediaMetadataVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingMediaMetadataVariant1 == null && embeddingMediaMetadataVariant2 == null && embeddingMediaMetadataVariant3 == null && embeddingMediaMetadataVariant4 == null && embeddingMediaMetadataVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant5).Name}");
                    embeddingMediaMetadataVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::TwelveLabs.EmbeddingMediaMetadata(
                embeddingMediaMetadataVariant1,

                embeddingMediaMetadataVariant2,

                embeddingMediaMetadataVariant3,

                embeddingMediaMetadataVariant4,

                embeddingMediaMetadataVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.EmbeddingMediaMetadata value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEmbeddingMediaMetadataVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingMediaMetadataVariant1!, typeInfo);
            }
            else if (value.IsEmbeddingMediaMetadataVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingMediaMetadataVariant2!, typeInfo);
            }
            else if (value.IsEmbeddingMediaMetadataVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingMediaMetadataVariant3!, typeInfo);
            }
            else if (value.IsEmbeddingMediaMetadataVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingMediaMetadataVariant4!, typeInfo);
            }
            else if (value.IsEmbeddingMediaMetadataVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.EmbeddingMediaMetadataVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingMediaMetadataVariant5!, typeInfo);
            }
        }
    }
}