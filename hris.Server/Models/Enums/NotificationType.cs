using System.Text.Json.Serialization;

namespace hris.Server.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NotificationType
    {
        Info,
        Warning,
        Success,
        Error,
        Approval,
        Announcement
    }
}