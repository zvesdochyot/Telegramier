using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class AnswerInlineQueryDto
{
    [JsonPropertyName("inline_query_id")]
    public string InlineQueryId { get; set; }

    [JsonPropertyName("results")]
    public InlineQueryResultDto[] Results { get; set; }

    [JsonPropertyName("cache_time")]
    public int? CacheTime { get; set; }

    [JsonPropertyName("is_personal")]
    public bool? IsPersonal { get; set; }

    [JsonPropertyName("next_offset")]
    public string? NextOffset { get; set; }

    [JsonPropertyName("button")]
    public InlineQueryResultsButtonDto? Button { get; set; }
}
