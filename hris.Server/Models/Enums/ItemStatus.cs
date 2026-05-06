using System.Text.Json.Serialization;

namespace hris.Server.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ItemStatus
    {
        Available,
        Unavailable,
        Archived
    }
}