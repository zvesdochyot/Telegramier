using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class DiceDto
{
    [JsonPropertyName("emoji")]
    public string Emoji { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}
