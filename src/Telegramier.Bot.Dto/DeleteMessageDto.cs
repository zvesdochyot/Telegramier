using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class DeleteMessageDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }
}
