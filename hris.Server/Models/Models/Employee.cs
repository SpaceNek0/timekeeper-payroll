using hris.Server.Models.Enums;

namespace hris.Server.Models.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string EmployeeNo { get; set; } = string.Empty;

        public string? Department { get; set; }

        public string? Position { get; set; }

        public EmploymentType EmploymentType { get; set; } = EmploymentType.FullTime;

        public EmploymentStatus EmploymentStatus { get; set; } = EmploymentStatus.Active;

        public DateTimeOffset DateHired { get; set; }

        public DateTimeOffset? DateSeparated { get; set; }

        public decimal BasicSalary { get; set; } = 0;

        public decimal DailyRate { get; set; } = 0;

        public decimal HourlyRate { get; set; } = 0;

        public string? SssNo { get; set; }

        public string? PhilhealthNo { get; set; }

        public string? PagibigNo { get; set; }

        public string? TinNo { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset ModifiedAt { get; set; } = DateTimeOffset.UtcNow;

        public User? User { get; set; }
    }
}