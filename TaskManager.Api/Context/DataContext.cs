using Microsoft.EntityFrameworkCore;
using TaskManager.Common.Models;

namespace TaskManager.Api.Context
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Observer> Observers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Common.Models.Task> Tasks { get; set; }
        public DbSet<Common.Models.TaskStatus> TaskStatuses { get; set; }
    }
}
