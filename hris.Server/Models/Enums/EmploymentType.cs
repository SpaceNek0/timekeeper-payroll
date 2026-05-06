using System.Text.Json.Serialization;

namespace hris.Server.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EmploymentType
    {
        FullTime,
        PartTime,
        Contractual,
        Probationary,
        Intern
    }
}