namespace Librio.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public ICollection<ReadingGoal> ReadingGoals { get; set; } = new List<ReadingGoal>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
