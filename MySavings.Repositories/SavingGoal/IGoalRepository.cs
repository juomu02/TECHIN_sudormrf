using MySavings.Entities;

namespace MySavings.Repositories
{
    public interface IGoalRepository
    {
        Task<Goal> CreateAsync(Goal goal);
    }
}