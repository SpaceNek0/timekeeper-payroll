using System.Text.Json.Serialization;

namespace hris.Server.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LeaveType
    {
        Vacation,
        Sick,
        Emergency,
        Maternity,
        Paternity,
        Bereavement,
        Unpaid
    }
}