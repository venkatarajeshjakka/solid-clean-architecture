using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Application.Exceptions;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRespository;

    public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        _mapper = mapper;
        _leaveTypeRespository = leaveTypeRepository;
    }

    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data
        var validator  = new CreateLeaveTypeCommandValidator(_leaveTypeRespository);
        var validationResult = await validator.ValidateAsync(request,cancellationToken);

        if(!validationResult.IsValid)
            throw new BadRequestException("Invalid Leavetype",validationResult);
        //Convert to domain entity object

        var leaveTypeToCreate = _mapper.Map<Domain.LeaveType>(request);

        //add to database

        await _leaveTypeRespository.CreateAsync(leaveTypeToCreate);

        //return record id
        return leaveTypeToCreate.Id;

    }
}
