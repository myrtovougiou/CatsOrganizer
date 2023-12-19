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
    public class VetService : BaseEntityService<Vet, VetRequest, VetDto, CatDbContext>, IVetService
    {
        public VetService(
            IMapper<Vet, VetDto> vetDtoMapper,
            IMapper<VetRequest, Vet> createRequestMapper,
            IMapper<Vet, VetRequest> vetToUpdateVetRequestMapper,
            IValidator<Vet> vetValidator,
            IBaseEntityRepository<Vet> vetRepository,
            IUnitOfWork<CatDbContext> unitOfWork) : base(vetDtoMapper, createRequestMapper, vetToUpdateVetRequestMapper, vetValidator, vetRepository, unitOfWork)
        { }
    }
}
