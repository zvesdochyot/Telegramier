using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BotCommandScopeDefaultDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
