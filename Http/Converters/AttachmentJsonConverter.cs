using BotMax.Http.Models.Attachments;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BotMax.Http.Converters;

public class AttachmentJsonConverter : JsonConverter<Attachment>
{
    public override Attachment? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;

        if (!root.TryGetProperty("type", out var typeProperty))
            throw new JsonException("Не найдено поле type");

        var type = typeProperty.GetString();

        // Выбираем конкретный тип на основе значения type
        Type targetType = type switch
        {
            "image" => typeof(ImageAttachment),
            "video" => typeof(VideoAttachment),
            "audio" => typeof(AudioAttachment),
            "file" => typeof(FileAttachment),
            "sticker" => typeof(StickerAttachment),
            "contact" => typeof(ContactAttachment),
            "share" => typeof(ShareAttachment),
            "location" => typeof(LocationAttachment),
            "inline_keyboard" => typeof(KeyboardAttachment),
            _ => throw new JsonException($"Неизвестный тип: {type}")
        };

        // Создаем новые опции, чтобы избежать рекурсии
        var newOptions = new JsonSerializerOptions(options);
        // Убираем наш конвертер из опций для внутренней десериализации
        newOptions.Converters.Remove(this);

        // Десериализуем в конкретный тип
        return (Attachment?)JsonSerializer.Deserialize(root.GetRawText(), targetType, newOptions);
    }

    public override void Write(Utf8JsonWriter writer, Attachment value, JsonSerializerOptions options)
    {
        // Создаем новые опции, чтобы избежать рекурсии
        var newOptions = new JsonSerializerOptions(options);
        newOptions.Converters.Remove(this);

        JsonSerializer.Serialize(writer, value, value.GetType(), newOptions);
    }
}