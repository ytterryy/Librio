using Librio.Domain.Enums;
using Librio.Domain.ValueObjects;

using Librio.Domain.Entities;
using System.Collections.Generic;

namespace Librio.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }

        public Genre Genre { get; set; }           
        public ReadingStatus ReadingStatus { get; set; } 

        public List<Rating> Ratings { get; set; } = new(); 
    }
}
