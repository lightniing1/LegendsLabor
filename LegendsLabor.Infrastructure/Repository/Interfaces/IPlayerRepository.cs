using LegendsLabor.Core.Domain.Entities;

namespace LegendsLabor.Infrastructure.Repository.Interfaces;

public interface IPlayerRepository
{
    Task<Player?> GetWithFullProfileAsync(int playerId);

    Task<Player?> GetWithInventoryAsync(int playerId);
    // Other domain-specific methods
}