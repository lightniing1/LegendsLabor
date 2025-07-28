using LegendsLabor.Core.Domain.Entities;
using LegendsLabor.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Infrastructure.Repository;

public class PlayerRepository : Repository<Player>, IPlayerRepository
{
    public PlayerRepository(LegendsLaborDbContext context) : base(context) { }
    
    public async Task<Player?> GetWithFullProfileAsync(int playerId)
    {
        return await _dbSet
            .Include(p => p.Skills)
            .Include(p => p.Items)
            .Include(p => p.StatModifiers)
            .Include(p => p.Bases)
            .Include(p => p.PlayerCollections)
            .Include(p => p.PlayerRecipes)
            .FirstOrDefaultAsync(p => p.PlayerId == playerId);
    }
    
    public async Task<Player?> GetWithInventoryAsync(int playerId)
    {
        return await _dbSet
            .Include(p => p.Items)
            .FirstOrDefaultAsync(p => p.PlayerId == playerId);
    }
}