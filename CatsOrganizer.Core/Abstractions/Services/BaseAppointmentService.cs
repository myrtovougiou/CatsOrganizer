using CatsOrganizer.Core.Abstractions.DataAccess;
using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Abstractions.Requests;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CatsOrganizer.Core.Abstractions.Services
{
    public abstract class BaseAppointmentService<TEntity, TRequest, TResult, TContext> : BaseEntityService<TEntity, TRequest, TResult, TContext>, IBaseAppointmentService<TRequest, TResult>
        where TRequest : BaseAppointmentRequest
        where TEntity : BaseAppointment
        where TContext : DbContext
    {
        protected new readonly IBaseAppointmentRepository<TEntity> _repository;

        public BaseAppointmentService(
            IMapper<TEntity, TResult> resultMapper,
            IMapper<TRequest, TEntity> entityMapper,
            IMapper<TEntity, TRequest> requestMapper,
            IValidator<TEntity> entityValidator,
            IBaseAppointmentRepository<TEntity> repository,
            IUnitOfWork<TContext> unitOfWork) 
            : base(resultMapper, entityMapper, requestMapper, entityValidator, repository, unitOfWork)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<IEnumerable<TResult>> GetByCatIdAsync(Guid id, CancellationToken token = default)
        {
            var result = await _repository.GetByCatIdAsync(id, token);
            return _resultMapper.Map(result);
        }
    }
}
