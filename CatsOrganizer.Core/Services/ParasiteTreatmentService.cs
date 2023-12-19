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
    public class ParasiteTreatmentService : BaseAppointmentService<ParasiteTreatment, ParasiteTreatmentRequest, ParasiteTreatmentDto, CatDbContext>, IParasiteTreatmentService
    {
        public ParasiteTreatmentService(
            IMapper<ParasiteTreatment, ParasiteTreatmentDto> parasiteTreatmentDtoMapper,
            IMapper<ParasiteTreatmentRequest, ParasiteTreatment> createRequestMapper,
            IMapper<ParasiteTreatment, ParasiteTreatmentRequest> parasiteTreatmentToUpdateParasiteTreatmentRequestMapper,
            IValidator<ParasiteTreatment> validator,
            IBaseAppointmentRepository<ParasiteTreatment> parasiteTreatmentRepository,
            IUnitOfWork<CatDbContext> unitOfWork) : base(parasiteTreatmentDtoMapper, createRequestMapper, parasiteTreatmentToUpdateParasiteTreatmentRequestMapper, validator, parasiteTreatmentRepository, unitOfWork)
        { }
    }
}
