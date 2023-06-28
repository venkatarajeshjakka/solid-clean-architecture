using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistance.DatabaseContext;

namespace HR.LeaveManagement.Persistance.Repositories;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{

    public LeaveRequestRepository(HrDatabaseContext context) : base(context)
    {
    }


}

