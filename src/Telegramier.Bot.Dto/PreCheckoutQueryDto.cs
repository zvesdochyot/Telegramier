using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class PreCheckoutQueryDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("from")]
    public UserDto From { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("total_amount")]
    public int TotalAmount { get; set; }

    [JsonPropertyName("invoice_payload")]
    public string InvoicePayload { get; set; }

    [JsonPropertyName("shipping_option_id")]
    public string? ShippingOptionId { get; set; }

    [JsonPropertyName("order_info")]
    public OrderInfoDto? OrderInfo { get; set; }
}
