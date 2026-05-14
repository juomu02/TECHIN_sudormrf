using MySavings.Entities;
using MySavings.Repositories;

namespace MySavings.Services
{
    public class UserService : IUserService
    {       public IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<int> AddAsync(string userName, string email, string password)
        {
            return await userRepository.AddAsync(userName, email, password);
        }

        public async Task<User> GetAsync(int userId)
        {
            return await userRepository.GetAsync(userId);
        }
    }
}