using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class PaidMediaPhotoDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("photo")]
    public PhotoSizeDto[] Photo { get; set; }
}
