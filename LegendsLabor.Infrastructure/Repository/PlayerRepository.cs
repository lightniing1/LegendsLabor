using LegendsLabor.Core.Domain.Entities;
using LegendsLabor.Core.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.Infrastructure.Repository;

public class PlayerRepository : Repository<Player>, IPlayerRepository
{
    public PlayerRepository(LegendsLaborDbContext context) : base(context) { }

}