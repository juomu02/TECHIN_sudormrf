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
        public int Add(string userName, string email, string password)
        {
            return userRepository.Add(userName, email, password);
        }

        public User Get(int userId)
        {
            return userRepository.Get(userId);
        }
    }
}