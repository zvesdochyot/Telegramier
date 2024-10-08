using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatBoostUpdatedDto
{
    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("boost")]
    public ChatBoostDto Boost { get; set; }
}
