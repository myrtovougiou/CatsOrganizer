using CatsOrganizer.Core.Dtos;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Abstractions.Services
{
    public interface IMicrochipService : IBaseAppointmentService<MicrochipRequest, MicrochipDto>
    {
    }
}
