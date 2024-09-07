using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ReplyKeyboardRemoveDto
{
    [JsonPropertyName("remove_keyboard")]
    public bool RemoveKeyboard { get; set; }

    [JsonPropertyName("selective")]
    public bool? Selective { get; set; }
}
