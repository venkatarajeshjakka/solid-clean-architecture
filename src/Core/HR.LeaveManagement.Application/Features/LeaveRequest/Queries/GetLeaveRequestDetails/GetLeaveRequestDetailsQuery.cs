using System;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Queries.GetLeaveRequestDetails
{
	public class GetLeaveRequestDetailsQuery : IRequest<LeaveRequestDetailsDto>
	{
		public int Id { get; set; }
	}
}

