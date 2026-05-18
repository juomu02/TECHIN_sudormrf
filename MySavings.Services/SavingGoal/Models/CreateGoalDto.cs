namespace MySavings.SavingGoal.Models
{
    public class CreateGoalDto
    {
        public string Title { get; set; }
        public decimal TargetAmount { get; set; }
        public int UserId { get; set; } = 1; // Default user ID
    }
}