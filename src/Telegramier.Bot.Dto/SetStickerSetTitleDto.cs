using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetStickerSetTitleDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}
