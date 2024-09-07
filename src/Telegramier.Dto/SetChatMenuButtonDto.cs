using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetChatMenuButtonDto
{
    [JsonPropertyName("chat_id")]
    public int? ChatId { get; set; }

    [JsonPropertyName("menu_button")]
    public MenuButtonDto? MenuButton { get; set; }
}
