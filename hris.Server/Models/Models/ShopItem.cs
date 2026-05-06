using hris.Server.Models.Enums;

namespace hris.Server.Models.Models
{
    public class ShopItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal Price { get; set; } = 0;

        public int PointsCost { get; set; } = 0;

        public string? Category { get; set; }

        public int Stock { get; set; } = 0;

        public ItemStatus Status { get; set; } = ItemStatus.Available;

        public string? ImageUrl { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset ModifiedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}