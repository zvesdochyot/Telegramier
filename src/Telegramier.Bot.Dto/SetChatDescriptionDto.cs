using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetChatDescriptionDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
