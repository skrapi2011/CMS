using Application.Databases.Relational.Models.Groups;
using Application.Databases.Relational.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databases.Relational.MsSql.Configurations.Groups
{
    public class GroupEFConfigurtion : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(t => t.GroupId).HasName($"{typeof(Group)}_pk");
            builder.Property(t => t.GroupId).HasDefaultValueSql("NEWID()");


            builder.HasMany(x => x.Students).WithMany(x => x.Groups)
                .UsingEntity($"{typeof(Student)}{typeof(Group)}",
                i => i.HasOne(typeof(Student)).WithMany()
                    .HasForeignKey($"{typeof(Student)}Id")
                    .HasConstraintName($"{typeof(Student)}{typeof(Group)}_{typeof(Student)}")
                    .OnDelete(DeleteBehavior.Restrict),
                j => j.HasOne(typeof(Group)).WithMany()
                    .HasForeignKey($"{typeof(Group)}Id")
                    .HasConstraintName($"{typeof(Student)}{typeof(Group)}_{typeof(Group)}")
                    .OnDelete(DeleteBehavior.Restrict)
                );
        }
    }
}
