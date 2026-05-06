using System.Text.Json.Serialization;

namespace hris.Server.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TimeLogStatus
    {
        Present,
        Absent,
        HalfDay,
        Holiday,
        Leave,
        RestDay
    }
}