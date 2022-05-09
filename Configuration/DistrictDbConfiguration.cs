using GraphQl_HotChochlete.Constant;
using GraphQl_HotChochlete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQl_HotChochlete.Configuration
{
    public class DistrictDbConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable(TableNames.District);
            builder.Property(t => t.Id)
                .ValueGeneratedNever();
            builder.Property(p => p.Name)
                .HasMaxLength(250)
                .IsRequired();
            builder.Property(p => p.DivisionId);
            builder.Property(p => p.DistrictBngName)
                .HasMaxLength(250)
                .HasColumnType(DbDataType.Nvarchar);
            builder.Property(p => p.Latitude);
            builder.Property(p => p.Longitude);
            builder.Property(p => p.WebUrl)
                .HasMaxLength(500);
        }
    }
}