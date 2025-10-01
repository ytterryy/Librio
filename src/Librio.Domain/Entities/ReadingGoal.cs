namespace Librio.Domain.Entities
{
    public class ReadingGoal
    {
        public int Id { get; set; }
        public int TargetBooks { get; set; }
        public DateTime Deadline { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
