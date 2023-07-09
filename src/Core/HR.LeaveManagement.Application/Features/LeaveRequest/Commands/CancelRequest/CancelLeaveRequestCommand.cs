using System;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.CancelRequest
{
	public class CancelLeaveRequestCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}

