using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BanChatSenderChatDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("sender_chat_id")]
    public int SenderChatId { get; set; }
}
