#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class AnalyzeResponse200JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.AnalyzeResponse200>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.AnalyzeResponse200 Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("finish_reason")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("usage")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::TwelveLabs.StreamAnalyzeResponse? streamAnalyzeResponse = default;
            global::TwelveLabs.NonStreamAnalyzeResponse? nonStreamAnalyzeResponse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.StreamAnalyzeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.StreamAnalyzeResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.StreamAnalyzeResponse).Name}");
                        streamAnalyzeResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.NonStreamAnalyzeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.NonStreamAnalyzeResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.NonStreamAnalyzeResponse).Name}");
                        nonStreamAnalyzeResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (streamAnalyzeResponse == null && nonStreamAnalyzeResponse == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.StreamAnalyzeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.StreamAnalyzeResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.StreamAnalyzeResponse).Name}");
                    streamAnalyzeResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.NonStreamAnalyzeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.NonStreamAnalyzeResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.NonStreamAnalyzeResponse).Name}");
                    nonStreamAnalyzeResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::TwelveLabs.AnalyzeResponse200(
                streamAnalyzeResponse,

                nonStreamAnalyzeResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.AnalyzeResponse200 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamAnalyzeResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.StreamAnalyzeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.StreamAnalyzeResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.StreamAnalyzeResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamAnalyzeResponse!.Value, typeInfo);
            }
            else if (value.IsNonStreamAnalyzeResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.NonStreamAnalyzeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.NonStreamAnalyzeResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.NonStreamAnalyzeResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NonStreamAnalyzeResponse!, typeInfo);
            }
        }
    }
}