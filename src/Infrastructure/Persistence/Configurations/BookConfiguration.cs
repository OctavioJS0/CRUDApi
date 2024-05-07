using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class BookConfiguration :  IEntityTypeConfiguration<Books>
{
    public void Configure(EntityTypeBuilder<Books> builder)
    {
        builder.Property(x => x.Id).HasColumnType("uniqueidentifier").ValueGeneratedOnAdd();
        builder.Property(x => x.Title).HasColumnType("varchar(150)").IsRequired();
        builder.Property(x => x.Synopsis).HasColumnType("varchar(250)").IsRequired();
        builder.Property(x => x.Genre).HasColumnType("varchar(50)").IsRequired();
        builder.Property(x => x.Price).HasColumnType("money").IsRequired();
        builder.Property(x => x.Active).HasColumnType("bit");
    }
}