using System;
using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistance.DatabaseContext;

namespace HR.LeaveManagement.Persistance.Repositories
{
	public class LeaveAllocationRepository : GenericRepository<LeaveAllocation> , ILeaveAllocationRepository
    {
		public LeaveAllocationRepository(HrDatabaseContext context): base(context)
		{
		}
	}
}

