using MySavings.Entities;

namespace MySavings.Services
{
    public interface IUserService
    {
        int Add(string userName, string email, string password);
        User Get(int userId);
    }
}