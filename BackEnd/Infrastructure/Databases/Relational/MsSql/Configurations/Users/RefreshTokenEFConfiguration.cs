using Application.Databases.Relational.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databases.Relational.MsSql.Configurations.Users
{
    public class RefreshTokenEFConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(x => x.Id).HasName($"{typeof(RefreshToken)}_pk");
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
