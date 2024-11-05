using Application.Databases.Relational.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databases.Relational.MsSql.Configurations.Users
{
    public class UserEFConfigurtion : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(x => x.UserId).HasName($"{typeof(User)}_pk");
            builder.Property(x => x.UserId).HasDefaultValueSql("NEWID()");

            //References
            //1 - *
            builder.HasMany(x => x.RefreshTokens).WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .HasConstraintName($"{typeof(User)}_{typeof(RefreshToken)}")
                .OnDelete(DeleteBehavior.Restrict);

            //1 - 0..1
            builder.HasOne(x => x.Student).WithOne(x => x.User)
                .HasForeignKey<Student>(x => x.StudentId)
                .HasConstraintName($"{typeof(User)}_{typeof(Student)}")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Teacher).WithOne(x => x.User)
                .HasForeignKey<Teacher>(x => x.TeacherId)
                .HasConstraintName($"{typeof(User)}_{typeof(Teacher)}")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Admin).WithOne(x => x.User)
               .HasForeignKey<Admin>(x => x.AdminId)
               .HasConstraintName($"{typeof(User)}_{typeof(Admin)}")
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
