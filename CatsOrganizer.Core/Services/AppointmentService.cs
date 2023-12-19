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
    public class AppointmentService : BaseAppointmentService<Appointment, AppointmentRequest, AppointmentDto, CatDbContext>, IAppointmentService
    {
        public AppointmentService (
            IMapper<Appointment, AppointmentDto> appointmentDtoMapper,
            IMapper<AppointmentRequest, Appointment> createRequestMapper,
            IMapper<Appointment, AppointmentRequest> appointmentToUpdateRequestMapper,
            IValidator<Appointment> validator,
            IBaseAppointmentRepository<Appointment> repository,
            IUnitOfWork<CatDbContext> unitOfWork) : base(appointmentDtoMapper, createRequestMapper, appointmentToUpdateRequestMapper, validator, repository, unitOfWork)
        {
            
        }

    }
}
