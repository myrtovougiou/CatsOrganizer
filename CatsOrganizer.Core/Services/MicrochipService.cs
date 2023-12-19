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
    public class MicrochipService : BaseAppointmentService<Microchip, MicrochipRequest, MicrochipDto, CatDbContext>, IMicrochipService
    {
        public MicrochipService(
            IMapper<Microchip, MicrochipDto> microchipDtoMapper,
            IMapper<MicrochipRequest, Microchip> createRequestMapper,
            IMapper<Microchip, MicrochipRequest> microchipToUpdateMicrochipRequestMapper,
            IValidator<Microchip> validator,
            IBaseAppointmentRepository<Microchip> microchipRepository,
            IUnitOfWork<CatDbContext> unitOfWork) : base(microchipDtoMapper, createRequestMapper, microchipToUpdateMicrochipRequestMapper, validator, microchipRepository, unitOfWork)
        { }
    }
}
