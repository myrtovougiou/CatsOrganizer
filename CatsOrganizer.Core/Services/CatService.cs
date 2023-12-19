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
    public class CatService : BaseEntityService<Cat, CatRequest, CatDto, CatDbContext>, ICatService
    {
        public CatService(
            IMapper<Cat, CatDto> catDtoMapper,
            IMapper<CatRequest, Cat> createRequestMapper,
            IMapper<Cat, CatRequest> catToUpdateRequestMapper,
            IValidator<Cat> validator,
            IBaseEntityRepository<Cat> repository,
            IUnitOfWork<CatDbContext> unitOfWork)
            : base(catDtoMapper, createRequestMapper, catToUpdateRequestMapper, validator, repository, unitOfWork)
        {
        }
    }
}
