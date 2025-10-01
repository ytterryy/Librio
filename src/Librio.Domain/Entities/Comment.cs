namespace Librio.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public required string Text { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }  
    }
}
