using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetChatTitleDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}
