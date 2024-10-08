using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BotCommandScopeChatDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }
}
