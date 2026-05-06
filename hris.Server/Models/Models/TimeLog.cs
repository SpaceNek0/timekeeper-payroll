using hris.Server.Models.Enums;

namespace hris.Server.Models.Models
{
    public class TimeLog
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }

        public DateTimeOffset LogDate { get; set; }

        public DateTimeOffset? TimeIn { get; set; }

        public DateTimeOffset? TimeOut { get; set; }

        public decimal HoursWorked { get; set; } = 0;

        public decimal OvertimeHours { get; set; } = 0;

        public decimal LateMinutes { get; set; } = 0;

        public decimal UndertimeMinutes { get; set; } = 0;

        public TimeLogStatus Status { get; set; } = TimeLogStatus.Present;

        public string? Remarks { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset ModifiedAt { get; set; } = DateTimeOffset.UtcNow;

        public Employee? Employee { get; set; }
    }
}