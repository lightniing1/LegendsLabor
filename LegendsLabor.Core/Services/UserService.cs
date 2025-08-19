using LegendsLabor.Core.Domain.Entities;
using LegendsLabor.Core.Repository.Interfaces;
using LegendsLabor.Core.Services.Interfaces;

namespace LegendsLabor.Core.Services
{
    public class UserService : CrudService<User, Guid>, IUserService
    {
        public UserService(IRepository<User> userRepository) : base(userRepository)
        {

        }
    }
}