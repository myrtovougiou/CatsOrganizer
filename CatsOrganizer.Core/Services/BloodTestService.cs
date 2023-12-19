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
    public class BloodTestService : BaseAppointmentService<BloodTest, BloodTestRequest, BloodTestDto, CatDbContext>, IBloodTestService
    {
        public BloodTestService(
            IMapper<BloodTest, BloodTestDto> bloodTestDtoMapper,
            IMapper<BloodTestRequest, BloodTest> createRequestMapper,
            IMapper<BloodTest, BloodTestRequest> bloodTestToUpdateBloodTestRequestMapper,
            IValidator<BloodTest> validator,
            IBaseAppointmentRepository<BloodTest> bloodTestRepository,
            IUnitOfWork<CatDbContext> unitOfWork) : base(bloodTestDtoMapper, createRequestMapper, bloodTestToUpdateBloodTestRequestMapper, validator, bloodTestRepository, unitOfWork)
        {

        }
    }
}
