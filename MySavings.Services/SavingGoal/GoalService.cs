using MySavings.Entities;
using MySavings.SavingGoal.Models;
using MySavings.Repositories;

namespace MySavings.Services
{
    public class GoalService : IGoalService
    {
        private readonly IGoalRepository _goalRepository;

        public GoalService(IGoalRepository goalRepository)
        {
            _goalRepository = goalRepository;
        }

        public async Task<Goal> CreateGoalAsync(CreateGoalDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Title))
                throw new Exception("Title is required");

            if (dto.TargetAmount <= 0)
                throw new Exception("Target amount must be > 0");

            var goal = new Goal
            {
                Title = dto.Title,
                TargetAmount = dto.TargetAmount,
                UserId = dto.UserId > 0 ? dto.UserId : 1,
                CurrentAmount = 0
            };

            return await _goalRepository.CreateAsync(goal);
        }
    }
}