using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BusinessOpeningHoursIntervalDto
{
    [JsonPropertyName("opening_minute")]
    public int OpeningMinute { get; set; }

    [JsonPropertyName("closing_minute")]
    public int ClosingMinute { get; set; }
}
