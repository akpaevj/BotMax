using BotMax.Http.Models.Buttons;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BotMax.Http.Converters;

public class ButtonJsonConverter : JsonConverter<Button>
{
    public override Button? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;

        if (!root.TryGetProperty("type", out var typeProperty))
            throw new JsonException("Не найдено поле type");

        var type = typeProperty.GetString();

        // Выбираем конкретный тип на основе значения type
        Type targetType = type switch
        {
            "link" => typeof(LinkButton),
            "message" => typeof(MessageButton),
            "callback" => typeof(CallbackButton),
            "request_geo_location" => typeof(RequestGeoLocationButton),
            "request_contact" => typeof(RequestContactButton),
            "open_app" => typeof(OpenAppButton),
            _ => throw new JsonException($"Неизвестный тип: {type}")
        };

        // Создаем новые опции, чтобы избежать рекурсии
        var newOptions = new JsonSerializerOptions(options);
        // Убираем наш конвертер из опций для внутренней десериализации
        newOptions.Converters.Remove(this);

        // Десериализуем в конкретный тип
        return (Button?)JsonSerializer.Deserialize(root.GetRawText(), targetType, newOptions);
    }

    public override void Write(Utf8JsonWriter writer, Button value, JsonSerializerOptions options)
    {
        // Создаем новые опции, чтобы избежать рекурсии
        var newOptions = new JsonSerializerOptions(options);
        newOptions.Converters.Remove(this);

        JsonSerializer.Serialize(writer, value, value.GetType(), newOptions);
    }
}
