using MySavings.Entities;
using MySavings.SavingGoal.Models;

namespace MySavings.Services
{
    public interface IGoalService
    {
        Task<Goal> CreateGoalAsync(CreateGoalDto dto);
    }
}