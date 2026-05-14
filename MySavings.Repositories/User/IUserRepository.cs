using MySavings.Entities;

namespace MySavings.Repositories
{
    public interface IUserRepository
    {
        Task<int> AddAsync(string userName, string email, string password);
        Task<User> GetAsync(int userId);
    }
}