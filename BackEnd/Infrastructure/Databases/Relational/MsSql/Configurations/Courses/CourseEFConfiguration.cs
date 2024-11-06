using Application.Databases.Relational.Models.Courses;
using Application.Databases.Relational.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databases.Relational.MsSql.Configurations.Courses
{
    public class CourseEFConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.CourseId).HasName($"{typeof(Course)}_pk");
            builder.Property(x => x.CourseId).HasDefaultValueSql("NEWID()");


            builder.HasOne(x => x.Teacher).WithMany(x => x.Courses)
                .HasForeignKey(x => x.TeacherId)
                .HasConstraintName($"{typeof(Course)}_{typeof(Teacher)}")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(x => x.CourseTimes).WithOne(x => x.Course)
                .HasForeignKey(x => x.CourseId)
                .HasConstraintName($"{typeof(Course)}_{typeof(CourseMeet)}")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
