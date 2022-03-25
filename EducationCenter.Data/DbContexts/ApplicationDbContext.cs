using EducationCenter.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EducationCenter.Data.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
