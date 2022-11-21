using Mentor.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Mentor.DAL
{
    public class MentorDbContext:DbContext
    {

        public MentorDbContext(DbContextOptions<MentorDbContext> opt) : base(opt)
        {
           
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<CoursTeacher> CoursTeachers { get; set; }

    }
}
