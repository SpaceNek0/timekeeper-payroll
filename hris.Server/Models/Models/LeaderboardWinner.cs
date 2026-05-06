namespace hris.Server.Models.Models
{
    public class LeaderboardWinner
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }

        public DateTimeOffset PeriodStart { get; set; }

        public DateTimeOffset PeriodEnd { get; set; }

        public int Rank { get; set; }

        public decimal Points { get; set; } = 0;

        public string? Category { get; set; }

        public string? Remarks { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset ModifiedAt { get; set; } = DateTimeOffset.UtcNow;

        public Employee? Employee { get; set; }
    }
}