using Application.Databases.Relational.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databases.Relational.MsSql.Configurations.Users
{
    public class StudentEFConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.StudentId).HasName($"{typeof(Student)}_pk");
        }
    }
}
