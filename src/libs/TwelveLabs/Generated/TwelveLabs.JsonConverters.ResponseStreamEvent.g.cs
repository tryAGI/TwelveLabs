#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class ResponseStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.ResponseStreamEvent>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.ResponseStreamEvent Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("response")) __score0++;
            if (__jsonProps.Contains("response.created_at")) __score0++;
            if (__jsonProps.Contains("response.id")) __score0++;
            if (__jsonProps.Contains("response.incomplete_details")) __score0++;
            if (__jsonProps.Contains("response.knowledge_store_id")) __score0++;
            if (__jsonProps.Contains("response.object")) __score0++;
            if (__jsonProps.Contains("response.output")) __score0++;
            if (__jsonProps.Contains("response.session_id")) __score0++;
            if (__jsonProps.Contains("response.status")) __score0++;
            if (__jsonProps.Contains("response.type")) __score0++;
            if (__jsonProps.Contains("response.usage")) __score0++;
            if (__jsonProps.Contains("sequence_number")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("response")) __score1++;
            if (__jsonProps.Contains("response.created_at")) __score1++;
            if (__jsonProps.Contains("response.id")) __score1++;
            if (__jsonProps.Contains("response.incomplete_details")) __score1++;
            if (__jsonProps.Contains("response.knowledge_store_id")) __score1++;
            if (__jsonProps.Contains("response.object")) __score1++;
            if (__jsonProps.Contains("response.output")) __score1++;
            if (__jsonProps.Contains("response.session_id")) __score1++;
            if (__jsonProps.Contains("response.status")) __score1++;
            if (__jsonProps.Contains("response.type")) __score1++;
            if (__jsonProps.Contains("response.usage")) __score1++;
            if (__jsonProps.Contains("sequence_number")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("response")) __score2++;
            if (__jsonProps.Contains("response.created_at")) __score2++;
            if (__jsonProps.Contains("response.id")) __score2++;
            if (__jsonProps.Contains("response.incomplete_details")) __score2++;
            if (__jsonProps.Contains("response.knowledge_store_id")) __score2++;
            if (__jsonProps.Contains("response.object")) __score2++;
            if (__jsonProps.Contains("response.output")) __score2++;
            if (__jsonProps.Contains("response.session_id")) __score2++;
            if (__jsonProps.Contains("response.status")) __score2++;
            if (__jsonProps.Contains("response.type")) __score2++;
            if (__jsonProps.Contains("response.usage")) __score2++;
            if (__jsonProps.Contains("sequence_number")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("response")) __score3++;
            if (__jsonProps.Contains("response.created_at")) __score3++;
            if (__jsonProps.Contains("response.id")) __score3++;
            if (__jsonProps.Contains("response.incomplete_details")) __score3++;
            if (__jsonProps.Contains("response.knowledge_store_id")) __score3++;
            if (__jsonProps.Contains("response.object")) __score3++;
            if (__jsonProps.Contains("response.output")) __score3++;
            if (__jsonProps.Contains("response.session_id")) __score3++;
            if (__jsonProps.Contains("response.status")) __score3++;
            if (__jsonProps.Contains("response.type")) __score3++;
            if (__jsonProps.Contains("response.usage")) __score3++;
            if (__jsonProps.Contains("sequence_number")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("item")) __score4++;
            if (__jsonProps.Contains("item.arguments")) __score4++;
            if (__jsonProps.Contains("item.call_id")) __score4++;
            if (__jsonProps.Contains("item.content")) __score4++;
            if (__jsonProps.Contains("item.id")) __score4++;
            if (__jsonProps.Contains("item.name")) __score4++;
            if (__jsonProps.Contains("item.output")) __score4++;
            if (__jsonProps.Contains("item.phase")) __score4++;
            if (__jsonProps.Contains("item.role")) __score4++;
            if (__jsonProps.Contains("item.status")) __score4++;
            if (__jsonProps.Contains("item.type")) __score4++;
            if (__jsonProps.Contains("output_index")) __score4++;
            if (__jsonProps.Contains("sequence_number")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("content_index")) __score5++;
            if (__jsonProps.Contains("item_id")) __score5++;
            if (__jsonProps.Contains("output_index")) __score5++;
            if (__jsonProps.Contains("part")) __score5++;
            if (__jsonProps.Contains("part.annotations")) __score5++;
            if (__jsonProps.Contains("part.text")) __score5++;
            if (__jsonProps.Contains("part.type")) __score5++;
            if (__jsonProps.Contains("sequence_number")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("content_index")) __score6++;
            if (__jsonProps.Contains("delta")) __score6++;
            if (__jsonProps.Contains("item_id")) __score6++;
            if (__jsonProps.Contains("output_index")) __score6++;
            if (__jsonProps.Contains("sequence_number")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("content_index")) __score7++;
            if (__jsonProps.Contains("item_id")) __score7++;
            if (__jsonProps.Contains("output_index")) __score7++;
            if (__jsonProps.Contains("sequence_number")) __score7++;
            if (__jsonProps.Contains("text")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("content_index")) __score8++;
            if (__jsonProps.Contains("item_id")) __score8++;
            if (__jsonProps.Contains("output_index")) __score8++;
            if (__jsonProps.Contains("part")) __score8++;
            if (__jsonProps.Contains("part.annotations")) __score8++;
            if (__jsonProps.Contains("part.text")) __score8++;
            if (__jsonProps.Contains("part.type")) __score8++;
            if (__jsonProps.Contains("sequence_number")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("item")) __score9++;
            if (__jsonProps.Contains("item.arguments")) __score9++;
            if (__jsonProps.Contains("item.call_id")) __score9++;
            if (__jsonProps.Contains("item.content")) __score9++;
            if (__jsonProps.Contains("item.id")) __score9++;
            if (__jsonProps.Contains("item.name")) __score9++;
            if (__jsonProps.Contains("item.output")) __score9++;
            if (__jsonProps.Contains("item.phase")) __score9++;
            if (__jsonProps.Contains("item.role")) __score9++;
            if (__jsonProps.Contains("item.status")) __score9++;
            if (__jsonProps.Contains("item.type")) __score9++;
            if (__jsonProps.Contains("output_index")) __score9++;
            if (__jsonProps.Contains("sequence_number")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("arguments")) __score10++;
            if (__jsonProps.Contains("item_id")) __score10++;
            if (__jsonProps.Contains("output_index")) __score10++;
            if (__jsonProps.Contains("sequence_number")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }

            global::TwelveLabs.ResponseStreamEventVariant1? responseStreamEventVariant1 = default;
            global::TwelveLabs.ResponseStreamEventVariant2? responseStreamEventVariant2 = default;
            global::TwelveLabs.ResponseStreamEventVariant3? responseStreamEventVariant3 = default;
            global::TwelveLabs.ResponseStreamEventVariant4? responseStreamEventVariant4 = default;
            global::TwelveLabs.ResponseStreamEventVariant5? responseOutputItemAdded = default;
            global::TwelveLabs.ResponseStreamEventVariant6? responseContentPartAdded = default;
            global::TwelveLabs.ResponseStreamEventVariant7? responseOutputTextDelta = default;
            global::TwelveLabs.ResponseStreamEventVariant8? responseOutputTextDone = default;
            global::TwelveLabs.ResponseStreamEventVariant9? responseContentPartDone = default;
            global::TwelveLabs.ResponseStreamEventVariant10? responseOutputItemDone = default;
            global::TwelveLabs.ResponseStreamEventVariant11? responseFunctionCallArgumentsDone = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant1).Name}");
                        responseStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant2).Name}");
                        responseStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant3).Name}");
                        responseStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant4).Name}");
                        responseStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant5).Name}");
                        responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant6).Name}");
                        responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant7).Name}");
                        responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant8).Name}");
                        responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant9).Name}");
                        responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant10).Name}");
                        responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant11).Name}");
                        responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant1).Name}");
                    responseStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant2).Name}");
                    responseStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant3).Name}");
                    responseStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant4).Name}");
                    responseStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant5).Name}");
                    responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant6).Name}");
                    responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant7).Name}");
                    responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant8).Name}");
                    responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant9).Name}");
                    responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant10).Name}");
                    responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseStreamEventVariant1 == null && responseStreamEventVariant2 == null && responseStreamEventVariant3 == null && responseStreamEventVariant4 == null && responseOutputItemAdded == null && responseContentPartAdded == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseContentPartDone == null && responseOutputItemDone == null && responseFunctionCallArgumentsDone == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant11).Name}");
                    responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::TwelveLabs.ResponseStreamEvent(
                responseStreamEventVariant1,

                responseStreamEventVariant2,

                responseStreamEventVariant3,

                responseStreamEventVariant4,

                responseOutputItemAdded,

                responseContentPartAdded,

                responseOutputTextDelta,

                responseOutputTextDone,

                responseContentPartDone,

                responseOutputItemDone,

                responseFunctionCallArgumentsDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.ResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponseStreamEventVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseStreamEventVariant1!, typeInfo);
            }
            else if (value.IsResponseStreamEventVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseStreamEventVariant2!, typeInfo);
            }
            else if (value.IsResponseStreamEventVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseStreamEventVariant3!, typeInfo);
            }
            else if (value.IsResponseStreamEventVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseStreamEventVariant4!, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded!, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded!, typeInfo);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDelta!, typeInfo);
            }
            else if (value.IsResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDone!, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone!, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.ResponseStreamEventVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.ResponseStreamEventVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.ResponseStreamEventVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone!, typeInfo);
            }
        }
    }
}