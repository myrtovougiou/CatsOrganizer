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
    public class OwnerService : BaseEntityService<Owner, OwnerRequest, OwnerDto, CatDbContext>, IOwnerService
    {
        public OwnerService(
            IMapper<Owner, OwnerDto> ownerDtoMapper,
            IMapper<OwnerRequest, Owner> createRequestMapper,
            IMapper<Owner, OwnerRequest> ownerToUpdateVetRequestMapper,
            IValidator<Owner> ownerValidator,
            IBaseEntityRepository<Owner> ownerRepository,
            IUnitOfWork<CatDbContext> unitOfWork) :base(ownerDtoMapper, createRequestMapper, ownerToUpdateVetRequestMapper, ownerValidator, ownerRepository, unitOfWork)
        { }
    }
}
