using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;
using CatsOrganizer.Core.Requests;
using FluentValidation;

namespace CatsOrganizer.Core.Services
{
    public class SurgeryService : BaseAppointmentService<Surgery, SurgeryRequest, SurgeryDto, CatDbContext>, ISurgeryService
    {
        public SurgeryService(
            IMapper<Surgery, SurgeryDto> surgeryDtoMapper,
            IMapper<SurgeryRequest, Surgery> createRequestMapper,
            IMapper<Surgery, SurgeryRequest> surgeryToUpdateSurgeryRequestMapper,
            IValidator<Surgery> validator,
            IBaseAppointmentRepository<Surgery> surgeryRepository,
            IUnitOfWork<CatDbContext> unitOfWork) : base(surgeryDtoMapper, createRequestMapper, surgeryToUpdateSurgeryRequestMapper, validator, surgeryRepository, unitOfWork)
        { }
    }
}
