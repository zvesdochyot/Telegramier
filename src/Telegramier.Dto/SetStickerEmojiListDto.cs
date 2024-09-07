using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetStickerEmojiListDto
{
    [JsonPropertyName("sticker")]
    public string Sticker { get; set; }

    [JsonPropertyName("emoji_list")]
    public List<string> EmojiList { get; set; }
}
