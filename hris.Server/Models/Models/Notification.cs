using hris.Server.Models.Enums;

namespace hris.Server.Models.Models
{
    public class Notification
    {
        // UUID PRIMARY KEY DEFAULT gen_random_uuid()
        public Guid Id { get; set; }

        // UUID NOT NULL REFERENCES users(id) ON DELETE CASCADE
        public Guid UserId { get; set; }

        // TEXT NOT NULL
        public string Title { get; set; } = string.Empty;

        // TEXT NOT NULL
        public string Message { get; set; } = string.Empty;

        // notification_type NOT NULL DEFAULT 'info'
        public NotificationType Type { get; set; } = NotificationType.Info;

        // UUID (nullable) — polymorphic reference
        public Guid? ReferenceId { get; set; }

        // TEXT (nullable) — name of the referenced table
        public string? ReferenceTable { get; set; }

        // BOOLEAN NOT NULL DEFAULT FALSE
        public bool IsRead { get; set; } = false;

        // TIMESTAMPTZ (nullable)
        public DateTimeOffset? ReadAt { get; set; }

        // TIMESTAMPTZ NOT NULL DEFAULT NOW()
        // Note: no modified_at — matches SQL schema (notifications are immutable)
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        // Navigation
        public User? User { get; set; }
    }
}