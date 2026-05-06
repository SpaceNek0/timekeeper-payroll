using System.Text.Json.Serialization;

namespace hris.Server.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PurchaseStatus
    {
        Pending,
        Completed,
        Cancelled,
        Refunded
    }
}