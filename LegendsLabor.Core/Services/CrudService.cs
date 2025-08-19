using LegendsLabor.Core.Domain;
using LegendsLabor.Core.Models;
using LegendsLabor.Core.Repository.Interfaces;
using LegendsLabor.Core.Services.Interfaces;

namespace LegendsLabor.Core.Services
{
    public class CrudService<T, TKey> : ICrudService<T, TKey> where T : class, IEntity<TKey>
    {
        protected readonly IRepository<T> _repository;

        public CrudService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<Result<T?>> GetByIdAsync(TKey id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
                return Result<T?>.Failure($"Entity with id {id} not found.");
            return Result<T?>.Success(entity);
        }

        public virtual async Task<Result<IEnumerable<T>>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return Result<IEnumerable<T>>.Success(entities);
        }

        public virtual async Task<Result<T>> CreateAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();
            return Result<T>.Success(entity);
        }

        public virtual async Task<Result<bool>> UpdateAsync(T entity)
        {
            var existingEntity = await _repository.GetByIdAsync(entity.Id);
            if (existingEntity == null)
                return Result<bool>.Failure($"Entity with id {entity.Id} not found.");
            await _repository.UpdateAsync(entity);
            await _repository.SaveChangesAsync();
            return Result<bool>.Success(true);
        }

        public virtual async Task<Result<bool>> DeleteAsync(TKey id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
                return Result<bool>.Failure($"Entity with id {id} not found.");
            await _repository.DeleteAsync(entity);
            await _repository.SaveChangesAsync();
            return Result<bool>.Success(true);
        }
    }
}
