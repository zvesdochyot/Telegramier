using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetMyShortDescriptionDto
{
    [JsonPropertyName("short_description")]
    public string? ShortDescription { get; set; }

    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }
}
