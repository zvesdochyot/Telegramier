using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class TransactionPartnerFragmentDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("withdrawal_state")]
    public RevenueWithdrawalStateDto? WithdrawalState { get; set; }
}
