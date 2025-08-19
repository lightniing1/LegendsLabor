using LegendsLabor.Core.Domain;
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

    public virtual async Task<T?> GetByIdAsync(TKey id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync() =>
        await _repository.GetAllAsync();

    public virtual async Task<T> CreateAsync(T entity)
    {
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity;
    }

    public virtual async Task UpdateAsync(T entity)
    {
        var existingEntity = await _repository.GetByIdAsync(entity.Id);
        if (existingEntity == null)
        {
            throw new KeyNotFoundException($"Entity with id {entity.Id} not found.");
        }
        
        await _repository.UpdateAsync(entity);
        await _repository.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(TKey id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return;

        await _repository.DeleteAsync(entity);
        await _repository.SaveChangesAsync();
    }
}
}
