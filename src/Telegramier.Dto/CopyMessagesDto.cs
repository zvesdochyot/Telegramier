using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class CopyMessagesDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    [JsonPropertyName("from_chat_id")]
    public object FromChatId { get; set; }

    [JsonPropertyName("message_ids")]
    public int[] MessageIds { get; set; }

    [JsonPropertyName("disable_notification")]
    public bool? DisableNotification { get; set; }

    [JsonPropertyName("protect_content")]
    public bool? ProtectContent { get; set; }

    [JsonPropertyName("remove_caption")]
    public bool? RemoveCaption { get; set; }
}
