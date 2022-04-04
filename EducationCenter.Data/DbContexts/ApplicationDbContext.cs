using EducationCenter.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EducationCenter.Data.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<TeacherGroup> TeachersGroups { get; set;}

        public virtual DbSet<Group> Groups { get; set; }

        public virtual DbSet<StudentGroup> StudentGroups { get; set; }

        public virtual DbSet<Student> Students { get; set; }
        
        public virtual DbSet<Subject> Subjects { get; set; }

        public virtual DbSet<RoomGroup> RoomGroups { get; set; }
        
        public virtual DbSet<Room> Rooms { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
