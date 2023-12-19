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
    public class SterilizationService : BaseAppointmentService<Sterilization, SterilizationRequest, SterilizationDto, CatDbContext>, ISterilizationService
    {
        public SterilizationService(
            IMapper<Sterilization, SterilizationDto> sterilizationDtoMapper,
            IMapper<SterilizationRequest, Sterilization> createRequestMapper,
            IMapper<Sterilization, SterilizationRequest> sterilizationToUpdateSterilizationRequestMapper,
            IValidator<Sterilization> validator,
            IBaseAppointmentRepository<Sterilization> sterilizationRepository,
            IUnitOfWork<CatDbContext> unitOfWork) : base(sterilizationDtoMapper, createRequestMapper, sterilizationToUpdateSterilizationRequestMapper, validator, sterilizationRepository, unitOfWork)
        { }
    }
}
