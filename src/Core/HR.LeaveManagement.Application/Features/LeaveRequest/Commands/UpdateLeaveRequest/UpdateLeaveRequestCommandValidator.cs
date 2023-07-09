using System;
using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Application.Features.LeaveRequest.Shared;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.UpdateLeaveRequest;

public class UpdateLeaveRequestCommandValidator : AbstractValidator<UpdateLeaveRequestCommand>
{
	private readonly ILeaveTypeRepository _leaveTypeRepository;
	private readonly ILeaveRequestRepository _leaveRequestRepository;
	public UpdateLeaveRequestCommandValidator(ILeaveTypeRepository leaveTypeRepository, ILeaveRequestRepository leaveRequestRepository)
	{
		_leaveRequestRepository = leaveRequestRepository;
		_leaveTypeRepository = leaveTypeRepository;

		Include(new BaseLeaveRequestValidator(_leaveTypeRepository));

		RuleFor(p => p.Id)
			.NotNull()
			.MustAsync(LeaveRequestMustExist)
			.WithMessage("{PropertyName} must be present");
	}

    private async Task<bool> LeaveRequestMustExist(int id, CancellationToken token)
    {
		var leaveAllocation = await _leaveRequestRepository.GetByIdAsync(id);
		return leaveAllocation != null;
    }
}

