using LegendsLabor.Core.Domain;

namespace LegendsLabor.Core.Services.Interfaces
{
    public interface ICrudService<T, TKey> where T : class, IEntity<TKey>
    {
        Task<T?> GetByIdAsync(TKey id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(TKey id);
    }
}
