using BotMax.Http.Models.Updates;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BotMax.Http.Converters;

public class UpdateJsonConverter : JsonConverter<Update>
{
    public override Update? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;

        if (!root.TryGetProperty("update_type", out var updateTypeProperty))
        {
            throw new JsonException("Missing update_type property");
        }

        var updateType = updateTypeProperty.GetString();

        // Выбираем конкретный тип на основе значения update_type
        Type targetType = updateType switch
        {
            "message_created" => typeof(MessageCreatedUpdate),
            "message_callback" => typeof(MessageCallbackUpdate),
            "message_edited" => typeof(MessageEditedUpdate),
            "message_removed" => typeof(MessageRemovedUpdate),
            "bot_added" => typeof(BotAddedUpdate),
            "bot_removed" => typeof(BotRemovedUpdate),
            "dialog_muted" => typeof(DialogMutedUpdate),
            "dialog_unmuted" => typeof(DialogUnmutedUpdate),
            "dialog_cleared" => typeof(DialogClearedUpdate),
            "dialog_removed" => typeof(DialogRemovedUpdate),
            "user_added" => typeof(UserAddedUpdate),
            "user_removed" => typeof(UserRemovedUpdate),
            "bot_started" => typeof(BotStartedUpdate),
            "bot_stopped" => typeof(BotStoppedUpdate),
            "chat_title_changed" => typeof(ChatTitleChangedUpdate),
            _ => throw new JsonException($"Unknown update type: {updateType}")
        };

        // Создаем новые опции, чтобы избежать рекурсии
        var newOptions = new JsonSerializerOptions(options);
        // Убираем наш конвертер из опций для внутренней десериализации
        newOptions.Converters.Remove(this);

        // Десериализуем в конкретный тип
        return (Update?)JsonSerializer.Deserialize(root.GetRawText(), targetType, newOptions);
    }

    public override void Write(Utf8JsonWriter writer, Update value, JsonSerializerOptions options)
    {
        // Создаем новые опции, чтобы избежать рекурсии
        var newOptions = new JsonSerializerOptions(options);
        newOptions.Converters.Remove(this);

        JsonSerializer.Serialize(writer, value, value.GetType(), newOptions);
    }
}
