﻿using System;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Queries.GetLeaveRequestDetails;

public class LeaveRequestDetailsDto
{
    public string RequestingEmployeeId { get; set; }

    public LeaveTypeDto LeaveType { get; set; }

    public int LeaveTypeId { get; set; }

    public DateTime DateRequested { get; set; }

    public string RequestComments { get; set; }

    public DateTime? DateActioned { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool? Approved { get; set; }

    public bool Cancelled { get; set; }
}

