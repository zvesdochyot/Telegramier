using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class WebAppDataDto
{
    [JsonPropertyName("data")]
    public string Data { get; set; }

    [JsonPropertyName("button_text")]
    public string ButtonText { get; set; }
}
