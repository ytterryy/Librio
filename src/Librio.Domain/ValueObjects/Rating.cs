using Librio.Domain.Entities;

namespace Librio.Domain.ValueObjects
{
    public class Rating
    {
        public int Id { get; set; }
        public int Value { get; set; }  // 1–5
        public int BookId { get; set; }

        public Book? Book { get; set; }  // зв'язок з Book
    }
}
