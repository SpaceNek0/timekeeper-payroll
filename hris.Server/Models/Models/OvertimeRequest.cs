using hris.Server.Models.Enums;

namespace hris.Server.Models.Models
{
    public class OvertimeRequest
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }

        public DateTimeOffset OtDate { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public DateTimeOffset EndTime { get; set; }

        public decimal OtHours { get; set; } = 0;

        public decimal OtRate { get; set; } = 1.25m;

        public string Reason { get; set; } = string.Empty;

        public RequestStatus Status { get; set; } = RequestStatus.Pending;

        public Guid? ApprovedBy { get; set; }

        public DateTimeOffset? ApprovedAt { get; set; }

        public string? ApproverRemarks { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset ModifiedAt { get; set; } = DateTimeOffset.UtcNow;

        public Employee? Employee { get; set; }
        public User? Approver { get; set; }
    }
}