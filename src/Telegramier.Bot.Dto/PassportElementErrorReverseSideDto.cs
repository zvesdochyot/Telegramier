using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class PassportElementErrorReverseSideDto
{
    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("file_hash")]
    public string FileHash { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}
