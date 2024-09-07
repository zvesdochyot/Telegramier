using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class PaidMediaPurchasedDto
{
    [JsonPropertyName("from")]
    public UserDto From { get; set; }

    [JsonPropertyName("paid_media_payload")]
    public string PaidMediaPayload { get; set; }
}
