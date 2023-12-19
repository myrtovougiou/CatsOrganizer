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
    public class VaccinationService : BaseAppointmentService<Vaccination, VaccinationRequest, VaccinationDto, CatDbContext>, IVaccinationService
    {
        public VaccinationService(
            IMapper<Vaccination, VaccinationDto> vaccinationDtoMapper,
            IMapper<VaccinationRequest, Vaccination> createRequestMapper,
            IMapper<Vaccination, VaccinationRequest> vaccinationToUpdateVaccinationRequestMapper,
            IValidator<Vaccination> validator,
            IBaseAppointmentRepository<Vaccination> vaccinationRepository,
            IUnitOfWork<CatDbContext> unitOfWork) : base(vaccinationDtoMapper, createRequestMapper, vaccinationToUpdateVaccinationRequestMapper, validator, vaccinationRepository, unitOfWork)
        { }
    }
}
