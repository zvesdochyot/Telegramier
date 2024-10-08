using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class RevokeChatInviteLinkDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("invite_link")]
    public string InviteLink { get; set; }
}
