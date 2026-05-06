using hris.Server.Models.Enums;

namespace hris.Server.Models.Models
{
    public class Purchase
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }

        public Guid ItemId { get; set; }

        public int Quantity { get; set; } = 1;

        public decimal UnitPrice { get; set; } = 0;

        public decimal TotalAmount { get; set; } = 0;

        public int PointsUsed { get; set; } = 0;

        public PurchaseStatus Status { get; set; } = PurchaseStatus.Pending;

        public DateTimeOffset PurchasedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset ModifiedAt { get; set; } = DateTimeOffset.UtcNow;

        public Employee? Employee { get; set; }
        public ShopItem? Item { get; set; }
    }
}