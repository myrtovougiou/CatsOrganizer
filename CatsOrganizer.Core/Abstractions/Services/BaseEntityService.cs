using CatsOrganizer.Core.Abstractions.DataAccess;
using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.Abstractions.Repositories;
using FluentValidation;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CatsOrganizer.Core.Abstractions.Services
{
    public abstract class BaseEntityService<TEntity, TRequest, TResult, TContext> : IBaseEntityService<TRequest, TResult>
        where TRequest : class
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        protected IMapper<TEntity, TResult> _resultMapper;
        protected readonly IMapper<TRequest, TEntity> _entityMapper;
        protected readonly IMapper<TEntity, TRequest> _requestMapper;
        protected IValidator<TEntity> _entityValidator;
        protected readonly IBaseEntityRepository<TEntity> _repository;
        protected readonly IUnitOfWork<TContext> _unitOfWork;

        public BaseEntityService(
            IMapper<TEntity, TResult> resultMapper,
            IMapper<TRequest, TEntity> entityMapper,
            IMapper<TEntity, TRequest> requestMapper,
            IValidator<TEntity> entityValidator,
            IBaseEntityRepository<TEntity> repository,
            IUnitOfWork<TContext> unitOfWork)
        {
            _resultMapper = resultMapper ?? throw new ArgumentNullException(nameof(resultMapper));
            _entityMapper = entityMapper ?? throw new ArgumentNullException(nameof(entityMapper));
            _requestMapper = requestMapper ?? throw new ArgumentNullException(nameof(requestMapper));
            _entityValidator = entityValidator ?? throw new ArgumentNullException(nameof(entityValidator));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<IEnumerable<TResult>> GetAllAsync(CancellationToken token = default)
        {
            var result = await _repository.GetAllAsync(token);
            return _resultMapper.Map(result);
        }

        public async Task<TResult> GetByIdAsync(Guid id, CancellationToken token = default)
        {
            var result = await _repository.GetAsync(id, token);
            return _resultMapper.Map(result);
        }

        public async Task<TResult> CreateAsync(TRequest request, CancellationToken token = default)
        {
            var entity = _entityMapper.Map(request);
            await _entityValidator.ValidateAndThrowAsync(entity);

            var result = await _repository.CreateAsync(entity, token);

            await _unitOfWork.SaveChangesAsync(token);
            return _resultMapper.Map(result);
        }


        public async Task<TResult> UpdateAsync(Guid id, JsonPatchDocument<TRequest> patchDocument, CancellationToken token = default)
        {
            var entity = await _repository.GetAsync(id, token);

            var updateRequest = _requestMapper.Map(entity);
            patchDocument.ApplyTo(updateRequest);
            var updatedEntity = _entityMapper.Map(updateRequest);
            await _entityValidator.ValidateAndThrowAsync(updatedEntity);

            var result = _repository.Update(entity, updatedEntity);

            await _unitOfWork.SaveChangesAsync(token);
            return _resultMapper.Map(result);
        }

        public async Task DeleteAsync(Guid id, CancellationToken token = default)
        {
            await _repository.RemoveAsync(id, token);
            await _unitOfWork.SaveChangesAsync(token);
        }
    }
}
