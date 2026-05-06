namespace hris.Server.Models.Models
{
    public class Inventory
    {
        public Guid Id { get; set; }

        public Guid ItemId { get; set; }

        public int QuantityIn { get; set; } = 0;

        public int QuantityOut { get; set; } = 0;

        public int QuantityOnHand { get; set; } = 0;

        public string Unit { get; set; } = "piece";

        public string? Remarks { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset ModifiedAt { get; set; } = DateTimeOffset.UtcNow;

        public ShopItem? Item { get; set; }
    }
}