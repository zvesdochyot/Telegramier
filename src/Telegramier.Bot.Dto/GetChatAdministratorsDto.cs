using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetChatAdministratorsDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }
}
