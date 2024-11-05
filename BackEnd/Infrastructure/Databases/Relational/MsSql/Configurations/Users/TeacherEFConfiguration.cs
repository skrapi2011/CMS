using Application.Databases.Relational.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databases.Relational.MsSql.Configurations.Users
{
    public class TeacherEFConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.TeacherId).HasName($"{typeof(Teacher)}_pk");
        }
    }
}
