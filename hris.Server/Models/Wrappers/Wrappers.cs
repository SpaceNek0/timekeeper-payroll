using hris.Server.Models.Models;

namespace hris.Server.Models.Wrappers
{
    public class EdgeNode<T>
    {
        public T Node { get; set; } = default!;
    }

    public class PageInfo
    {
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
        public string? StartCursor { get; set; }
        public string? EndCursor { get; set; }
    }

    public class Collection<T>
    {
        public List<EdgeNode<T>> Edges { get; set; } = new();
        public PageInfo? PageInfo { get; set; }
    }

    public class UsersResponse               { public Collection<User> UsersCollection { get; set; } = new(); }
    public class EmployeesResponse           { public Collection<Employee> EmployeesCollection { get; set; } = new(); }
    public class PayrollsResponse            { public Collection<Payroll> PayrollsCollection { get; set; } = new(); }
    public class TimeLogsResponse            { public Collection<TimeLog> TimeLogsCollection { get; set; } = new(); }
    public class LogRequestsResponse         { public Collection<LogRequest> LogRequestsCollection { get; set; } = new(); }
    public class OvertimeRequestsResponse    { public Collection<OvertimeRequest> OvertimeRequestsCollection { get; set; } = new(); }
    public class LeaveRequestsResponse       { public Collection<LeaveRequest> LeaveRequestsCollection { get; set; } = new(); }
    public class ShopItemsResponse           { public Collection<ShopItem> ShopItemsCollection { get; set; } = new(); }
    public class InventoriesResponse         { public Collection<Inventory> InventoriesCollection { get; set; } = new(); }
    public class PurchasesResponse           { public Collection<Purchase> PurchasesCollection { get; set; } = new(); }
    public class LeaderboardWinnersResponse  { public Collection<LeaderboardWinner> LeaderboardWinnersCollection { get; set; } = new(); }
    public class NotificationsResponse       { public Collection<Notification> NotificationsCollection { get; set; } = new(); }
}