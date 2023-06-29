using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Application.Exceptions;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType
{
    public class DeleteLeaveTypeHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;


        public DeleteLeaveTypeHandler(ILeaveTypeRepository leaveTypeRepository) =>
            _leaveTypeRepository = leaveTypeRepository;


        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            //retrive domain entity object

            var leaveTypeToDelete = await _leaveTypeRepository.GetByIdAsync(request.Id);

            //verify that record exists
            if (leaveTypeToDelete is null)
                throw new NotFoundException(nameof(LeaveType), request.Id);

            //remove from database
            await _leaveTypeRepository.DeleteAsync(leaveTypeToDelete);

            //return unit value
            return Unit.Value;
        }
    }
}

