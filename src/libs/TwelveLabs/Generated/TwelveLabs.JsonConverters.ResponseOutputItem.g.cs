#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class ResponseOutputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.ResponseOutputItem>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.ResponseOutputItem Read(
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
            if (__jsonProps.Contains("arguments")) __score0++;
            if (__jsonProps.Contains("call_id")) __score0++;
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("output")) __score0++;
            if (__jsonProps.Contains("phase")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("arguments")) __score1++;
            if (__jsonProps.Contains("call_id")) __score1++;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("output")) __score1++;
            if (__jsonProps.Contains("phase")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("arguments")) __score2++;
            if (__jsonProps.Contains("call_id")) __score2++;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("output")) __score2++;
            if (__jsonProps.Contains("phase")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("action")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::TwelveLabs.ResponseOutputItemVariant1? responseOutputItemVariant1 = default;
            global::TwelveLabs.ResponseOutputItemVariant2? responseOutputItemVariant2 = default;
            global::TwelveLabs.ResponseOutputItemVariant3? responseOutputItemVariant3 = default;
            global::TwelveLabs.ResponseOutputItemVariant4? jockeyWebSearch = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant1).Name}");
                        responseOutputItemVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant2).Name}");
                        responseOutputItemVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant3).Name}");
                        responseOutputItemVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant4).Name}");
                        jockeyWebSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responseOutputItemVariant1 == null && responseOutputItemVariant2 == null && responseOutputItemVariant3 == null && jockeyWebSearch == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant1).Name}");
                    responseOutputItemVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseOutputItemVariant1 == null && responseOutputItemVariant2 == null && responseOutputItemVariant3 == null && jockeyWebSearch == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant2).Name}");
                    responseOutputItemVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseOutputItemVariant1 == null && responseOutputItemVariant2 == null && responseOutputItemVariant3 == null && jockeyWebSearch == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant3).Name}");
                    responseOutputItemVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseOutputItemVariant1 == null && responseOutputItemVariant2 == null && responseOutputItemVariant3 == null && jockeyWebSearch == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant4).Name}");
                    jockeyWebSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::TwelveLabs.ResponseOutputItem(
                responseOutputItemVariant1,

                responseOutputItemVariant2,

                responseOutputItemVariant3,

                jockeyWebSearch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.ResponseOutputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponseOutputItemVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputItemVariant1(), typeInfo);
            }
            else if (value.IsResponseOutputItemVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputItemVariant2(), typeInfo);
            }
            else if (value.IsResponseOutputItemVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputItemVariant3(), typeInfo);
            }
            else if (value.IsJockeyWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseOutputItemVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseOutputItemVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseOutputItemVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickJockeyWebSearch(), typeInfo);
            }
        }
    }
}