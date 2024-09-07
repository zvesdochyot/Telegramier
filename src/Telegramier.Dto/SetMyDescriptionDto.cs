using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetMyDescriptionDto
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }
}
