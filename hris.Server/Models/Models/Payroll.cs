using hris.Server.Models.Enums;

namespace hris.Server.Models.Models
{
    public class Payroll
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }

        public DateTimeOffset PeriodStart { get; set; }

        public DateTimeOffset PeriodEnd { get; set; }

        public decimal BasicPay { get; set; } = 0;

        public decimal OvertimePay { get; set; } = 0;

        public decimal HolidayPay { get; set; } = 0;

        public decimal Allowances { get; set; } = 0;

        public decimal GrossPay { get; set; } = 0;

        public decimal SssDeduction { get; set; } = 0;

        public decimal PhilhealthDeduction { get; set; } = 0;

        public decimal PagibigDeduction { get; set; } = 0;

        public decimal TaxDeduction { get; set; } = 0;

        public decimal OtherDeductions { get; set; } = 0;

        public decimal TotalDeductions { get; set; } = 0;

        public decimal NetPay { get; set; } = 0;

        public PayrollStatus Status { get; set; } = PayrollStatus.Draft;

        public DateTimeOffset? ReleasedAt { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset ModifiedAt { get; set; } = DateTimeOffset.UtcNow;

        public Employee? Employee { get; set; }
    }
}