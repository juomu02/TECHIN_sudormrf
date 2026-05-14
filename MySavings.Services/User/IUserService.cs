using MySavings.Entities;

namespace MySavings.Services
{
    public interface IUserService
    {
        Task<int> AddAsync(string userName, string email, string password);
        Task<User> GetAsync(int userId);
    }
}