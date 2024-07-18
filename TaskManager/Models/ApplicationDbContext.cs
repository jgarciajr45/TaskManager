using Microsoft.EntityFrameworkCore;

namespace TaskManager.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Users = Set<User>();
            Tasks = Set<Task>();
        }

        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Task> Tasks { get; set; } = default!;
    }
}