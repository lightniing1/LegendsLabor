using LegendsLabor.Core.Domain.Entities;
using LegendsLabor.Infrastructure.Repository.Interfaces;

namespace LegendsLabor.Core.Services
{
    public class UserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
