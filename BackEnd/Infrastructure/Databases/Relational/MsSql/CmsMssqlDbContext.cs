using Application.Databases.Relational;
using Application.Databases.Relational.Models.Users;
using Infrastructure.Databases.Relational.MsSql.Configurations.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Databases.Relational.MsSql
{
    public class CmsMssqlDbContext : CmsDbContext
    {
        //values
        private readonly string _cnnectionString;


        //Constructor
        public CmsMssqlDbContext
            (
            IConfiguration configuration
            )
        {
#warning Implement Exception Handling if string Isnull OrWhiteSpace
            _cnnectionString = configuration.GetSection("ConnectionStrings")["MsSqlString"];
        }


        //======================================================================================================
        //======================================================================================================
        //======================================================================================================
        //Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_cnnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<User>(new UserEFConfigurtion());
            modelBuilder.ApplyConfiguration<RefreshToken>(new RefreshTokenEFConfiguration());
            modelBuilder.ApplyConfiguration<Student>(new StudentEFConfiguration());
            modelBuilder.ApplyConfiguration<Teacher>(new TeacherEFConfiguration());
            modelBuilder.ApplyConfiguration<Admin>(new AdminEFConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
