#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class VideoContextJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.VideoContext>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.VideoContext Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("asset_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("base64_string")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::TwelveLabs.VideoContext0? videoContext0 = default;
            global::TwelveLabs.VideoContext1? videoContext1 = default;
            global::TwelveLabs.VideoContext2? videoContext2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContext0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContext0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContext0).Name}");
                        videoContext0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContext1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContext1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContext1).Name}");
                        videoContext1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContext2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContext2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContext2).Name}");
                        videoContext2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (videoContext0 == null && videoContext1 == null && videoContext2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContext0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContext0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContext0).Name}");
                    videoContext0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContext1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContext1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContext1).Name}");
                    videoContext1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContext2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContext2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContext2).Name}");
                    videoContext2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::TwelveLabs.VideoContext(
                videoContext0,

                videoContext1,

                videoContext2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.VideoContext value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideoContext0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContext0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContext0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContext0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoContext0!, typeInfo);
            }
            else if (value.IsVideoContext1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContext1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContext1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContext1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoContext1!, typeInfo);
            }
            else if (value.IsVideoContext2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.VideoContext2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.VideoContext2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.VideoContext2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoContext2!, typeInfo);
            }
        }
    }
}