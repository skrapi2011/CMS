using Application.Databases.Relational.Models.Courses;
using Application.Databases.Relational.Models.Groups;
using Application.Databases.Relational.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Application.Databases.Relational
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext(DbContextOptions options) : base(options)
        {
        }

        protected CmsDbContext()
        {
        }


        //Users Part
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }


        //Courses Part
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseMeet> CourseTimes { get; set; }


        //Group Part
        public virtual DbSet<Group> Groups { get; set; }
    }
}
