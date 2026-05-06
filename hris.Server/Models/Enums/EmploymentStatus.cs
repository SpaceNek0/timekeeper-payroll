using System.Text.Json.Serialization;

namespace hris.Server.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EmploymentStatus
    {
        Active,
        Inactive,
        Resigned,
        Terminated,
        Retired,
        OnLeave
    }
}