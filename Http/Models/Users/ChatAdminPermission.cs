using System.Text.Json.Serialization;

namespace BotMax.Http.Models.Users;

/// <summary>
/// Права администратора чата
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChatAdminPermission
{
    /// <summary>Читать все сообщения</summary>
    [JsonPropertyName("read_all_messages")]
    ReadAllMessages,

    /// <summary>Добавлять/удалять участников</summary>
    [JsonPropertyName("add_remove_members")]
    AddRemoveMembers,

    /// <summary>Добавлять администраторов</summary>
    [JsonPropertyName("add_admins")]
    AddAdmins,

    /// <summary>Изменять информацию о чате</summary>
    [JsonPropertyName("change_chat_info")]
    ChangeChatInfo,

    /// <summary>Закреплять сообщения</summary>
    [JsonPropertyName("pin_message")]
    PinMessage,

    /// <summary>Писать сообщения</summary>
    [JsonPropertyName("write")]
    Write,

    /// <summary>Изменять ссылку на чат</summary>
    [JsonPropertyName("edit_link")]
    EditLink,

    /// <summary>Редактировать, удалять, закреплять любые сообщения</summary>
    [JsonPropertyName("post_edit_delete_message")]
    PostEditDeleteMessage,

    /// <summary>Редактировать сообщения</summary>
    [JsonPropertyName("edit_message")]
    EditMessage,

    /// <summary>Удалять сообщения</summary>
    [JsonPropertyName("delete_message")]
    DeleteMessage,

    /// <summary>Совершать звонки</summary>
    [JsonPropertyName("can_call")]
    CanCall
}