using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BotCommandScopeAllChatAdministratorsDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
