using LegendsLabor.Core.Domain;
using LegendsLabor.Core.Models;

namespace LegendsLabor.Core.Services.Interfaces
{
    public interface ICrudService<T, TKey> where T : class, IEntity<TKey>
    {
        Task<Result<T?>> GetByIdAsync(TKey id);
        Task<Result<IEnumerable<T>>> GetAllAsync();
        Task<Result<T>> CreateAsync(T entity);
        Task<Result<bool>> UpdateAsync(T entity);
        Task<Result<bool>> DeleteAsync(TKey id);
    }
}
