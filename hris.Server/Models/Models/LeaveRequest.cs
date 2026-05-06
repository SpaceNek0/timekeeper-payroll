using hris.Server.Models.Enums;

namespace hris.Server.Models.Models
{
    public class LeaveRequest
    {
        public Guid Id { get; set; }
 
        public Guid EmployeeId { get; set; }
 
        public LeaveType LeaveType { get; set; } = LeaveType.Vacation;
 
        public DateTimeOffset StartDate { get; set; }
 
        public DateTimeOffset EndDate { get; set; }
 
        public decimal Days { get; set; } = 1;
 
        public string? Reason { get; set; }
 
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