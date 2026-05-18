using MySavings.Data;
using MySavings.Entities;

namespace MySavings.Repositories
{
    public class GoalRepository : IGoalRepository
    {
        private readonly MySavingsDbContext _context;

        public GoalRepository(MySavingsDbContext context)
        {
            _context = context;
        }

        public async Task<Goal> CreateAsync(Goal goal)
        {
            _context.Goals.Add(goal);
            await _context.SaveChangesAsync();
            return goal;
        }
    }
}