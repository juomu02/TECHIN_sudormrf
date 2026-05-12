using MySavings.Entities;

namespace MySavings.Repositories
{
    public interface IUserRepository
    {
        int Add(string userName, string email, string password);
        User Get(int userId);
    }
}