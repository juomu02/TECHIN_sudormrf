using MySavings.Data;
using MySavings.Entities;

namespace MySavings.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MySavingsDbContext dbContext;

        public UserRepository(MySavingsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public int Add(string userName, string email, string password)
        {
           var user = new User
            {
                UserName = userName,
                Email = email,
                PasswordHash = password,
                PasswordSalt = "salt",
                Iterations = 10000
            };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user.Id;
        }

        public User Get(int userId)
        {
            return dbContext.Users.Find(userId);
        }
    }
}