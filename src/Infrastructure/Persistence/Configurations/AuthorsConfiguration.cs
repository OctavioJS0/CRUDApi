using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class AuthorsConfiguration : IEntityTypeConfiguration<Authors>
{
    public void Configure(EntityTypeBuilder<Authors> builder)
    {
        builder.Property(x => x.Id).HasColumnType("uniqueidentifier").ValueGeneratedOnAdd();
        builder.Property(x => x.Name).HasColumnType("varchar(150)").IsRequired();
        builder.Property(x => x.Birthday).HasColumnType("date").IsRequired();
        builder.Property(x => x.Nationality).HasColumnType("varchar(50)").IsRequired();
        builder.Property(x => x.Active).HasColumnType("bit");
    }
}