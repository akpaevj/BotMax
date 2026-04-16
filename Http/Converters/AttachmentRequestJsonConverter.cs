using BotMax.Http.Models.AttachmentRequests;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BotMax.Http.Converters;

public class AttachmentRequestJsonConverter : JsonConverter<AttachmentRequest>
{
    public override AttachmentRequest? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;

        if (!root.TryGetProperty("type", out var typeProperty))
            throw new JsonException("Не найдено поле type");

        var type = typeProperty.GetString();

        // Выбираем конкретный тип на основе значения type
        Type targetType = type switch
        {
            "image" => typeof(ImageAttachmentRequest),
            "video" => typeof(VideoAttachmentRequest),
            "audio" => typeof(AudioAttachmentRequest),
            "file" => typeof(FileAttachmentRequest),
            "sticker" => typeof(StickerAttachmentRequest),
            "contact" => typeof(ContactAttachmentRequest),
            "share" => typeof(ShareAttachmentRequest),
            "location" => typeof(LocationAttachmentRequest),
            "inline_keyboard" => typeof(InlineKeyboardAttachmentRequest),
            _ => throw new JsonException($"Неизвестный тип: {type}")
        };

        // Создаем новые опции, чтобы избежать рекурсии
        var newOptions = new JsonSerializerOptions(options);
        // Убираем наш конвертер из опций для внутренней десериализации
        newOptions.Converters.Remove(this);

        // Десериализуем в конкретный тип
        return (AttachmentRequest?)JsonSerializer.Deserialize(root.GetRawText(), targetType, newOptions);
    }

    public override void Write(Utf8JsonWriter writer, AttachmentRequest value, JsonSerializerOptions options)
    {
        // Создаем новые опции, чтобы избежать рекурсии
        var newOptions = new JsonSerializerOptions(options);
        newOptions.Converters.Remove(this);

        JsonSerializer.Serialize(writer, value, value.GetType(), newOptions);
    }
}
