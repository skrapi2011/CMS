using Application.Databases.Relational.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databases.Relational.MsSql.Configurations.Users
{
    public class AdminEFConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.AdminId).HasName($"{typeof(Admin)}_pk");
        }
    }
}
