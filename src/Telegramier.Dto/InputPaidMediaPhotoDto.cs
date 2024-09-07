using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InputPaidMediaPhotoDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("media")]
    public string Media { get; set; }
}
