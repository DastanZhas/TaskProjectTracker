using TaskProjectTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskProjectTracker.Data_Access_Layer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().ToTable("Project");
            modelBuilder.Entity<ProjectTask>().ToTable("ProjectTask");
        }
    }
}
