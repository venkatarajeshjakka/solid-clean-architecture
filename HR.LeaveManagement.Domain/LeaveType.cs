using System;
namespace HR.LeaveManagement.Domain;

public class LeaveType
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int DefaultDays { get; set; }
}


