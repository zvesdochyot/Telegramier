using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ReactionTypeEmojiDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("emoji")]
    public string Emoji { get; set; }
}
