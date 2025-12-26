using Microsoft.EntityFrameworkCore;
using TaskManager.Infrastructure.Entities;

namespace TaskManager.Infrastructure.Persistence
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskEntity> Tasks => Set<TaskEntity>();
    }
}
