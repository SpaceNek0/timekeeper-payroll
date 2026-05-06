using System.Text.Json.Serialization;

namespace hris.Server.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserRole
    {
        Admin,
        Manager,
        Employee,
        Viewer
    }
}