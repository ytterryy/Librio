using Librio.Domain.Entities;
using Librio.Domain.Enums;
using Librio.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Librio.Infrastructure.Data
{
    public class LibrioDbContext : DbContext
    {
        public LibrioDbContext(DbContextOptions<LibrioDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ReadingGoal> ReadingGoals { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rating>()
                .Property(r => r.Value)
                .IsRequired()
                .HasDefaultValue(1);

            modelBuilder.Entity<Comment>()
                .Property(c => c.Text)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
