namespace MySavings.Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal TargetAmount { get; set; }

        public decimal CurrentAmount { get; set; } = 0;

        public int? UserId { get; set; }

        public User? User { get; set; }
    }
}