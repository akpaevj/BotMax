using BotMax.Http.Models.Buttons;
using BotMax.Http.Models.MarkupElements;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BotMax.Http.Converters;

public class MarkupElementJsonConverter : JsonConverter<MarkupElement>
{
    public override MarkupElement? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;

        if (!root.TryGetProperty("type", out var typeProperty))
            throw new JsonException("Не найдено поле type");

        var type = typeProperty.GetString();

        // Выбираем конкретный тип на основе значения type
        Type targetType = type switch
        {
            "emphasized" => typeof(EmphasizedMarkupElement),
            "link" => typeof(LinkMarkupElement),
            "monospaced" => typeof(MonospacedMarkupElement),
            "strikethrough" => typeof(MonospacedMarkupElement),
            "strong" => typeof(StrongMarkupElement),
            "underline" => typeof(UnderlineMarkupElement),
            "user_mention" => typeof(UserMentionMarkupElement),
            _ => throw new JsonException($"Неизвестный тип: {type}")
        };

        // Создаем новые опции, чтобы избежать рекурсии
        var newOptions = new JsonSerializerOptions(options);
        // Убираем наш конвертер из опций для внутренней десериализации
        newOptions.Converters.Remove(this);

        // Десериализуем в конкретный тип
        return (MarkupElement?)JsonSerializer.Deserialize(root.GetRawText(), targetType, newOptions);
    }

    public override void Write(Utf8JsonWriter writer, MarkupElement value, JsonSerializerOptions options)
    {
        // Создаем новые опции, чтобы избежать рекурсии
        var newOptions = new JsonSerializerOptions(options);
        newOptions.Converters.Remove(this);

        JsonSerializer.Serialize(writer, value, value.GetType(), newOptions);
    }
}
