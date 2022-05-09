using GraphQl_HotChochlete.Constant;
using GraphQl_HotChochlete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQl_HotChochlete.Configuration
{
    public class EducationalInstituteDbConfiguration : IEntityTypeConfiguration<EducationalInstitute>
    {
        public void Configure(EntityTypeBuilder<EducationalInstitute> builder)
        {
            builder.ToTable(TableNames.EducationalInstitute);
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.CreatedBy)
                .IsRequired();
            builder.Property(p => p.DateCreated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.LastUpdated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.UpdatedBy);


            builder.HasOne(p => p.CreatedUserInfo)
                .WithMany(p => p.CreatedEducationalInstitute)
                .HasForeignKey(p => p.CreatedBy);
            builder.HasOne(p => p.UpdatedUserInfo)
                .WithMany(p => p.UpdatedEducationalInstitute)
                .HasForeignKey(p => p.UpdatedBy);
        }


    }
}
