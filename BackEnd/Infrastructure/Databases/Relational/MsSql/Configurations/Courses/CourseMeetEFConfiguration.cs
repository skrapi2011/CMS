using Application.Databases.Relational.Models.Courses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databases.Relational.MsSql.Configurations.Courses
{
    internal class CourseMeetEFConfiguration : IEntityTypeConfiguration<CourseMeet>
    {
        public void Configure(EntityTypeBuilder<CourseMeet> builder)
        {
            builder.HasKey(t => t.CourseTimeId).HasName($"{typeof(CourseMeet)}_pk");
            builder.Property(t => t.CourseTimeId).HasDefaultValueSql("NEWID()");
        }
    }
}
