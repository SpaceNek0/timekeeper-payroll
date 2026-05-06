using hris.Server.Models.Enums;

namespace hris.Server.Models.Models
{
    public class LogRequest
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }

        public Guid? TimeLogId { get; set; }

        public DateTimeOffset LogDate { get; set; }

        public DateTimeOffset? RequestedTimeIn { get; set; }

        public DateTimeOffset? RequestedTimeOut { get; set; }

        public string Reason { get; set; } = string.Empty;

        public RequestStatus Status { get; set; } = RequestStatus.Pending;

        public Guid? ReviewedBy { get; set; }

        public DateTimeOffset? ReviewedAt { get; set; }

        public string? ReviewerRemarks { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset ModifiedAt { get; set; } = DateTimeOffset.UtcNow;

        public Employee? Employee { get; set; }
        public TimeLog? TimeLog { get; set; }
        public User? Reviewer { get; set; }
    }
}