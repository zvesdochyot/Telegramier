using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ApproveChatJoinRequestDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}
