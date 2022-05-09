using GraphQl_HotChochlete.Constant;
using GraphQl_HotChochlete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQl_HotChochlete.Configuration
{
    public class BusinessCardDbConfiguration : IEntityTypeConfiguration<BusinessCard>
    {
        public void Configure(EntityTypeBuilder<BusinessCard> builder)
        {
            builder.ToTable(TableNames.BusinessCard);
            builder.Property(t => t.Id);
            builder.Property(p => p.StakeholderInfoId)
                .HasMaxLength(450)
                .IsRequired();
            builder.Property(p => p.Uri)
                .IsRequired();
            builder.Property(p => p.FileName)
                .IsRequired();
            builder.Property(p => p.IsPrivate)
                .HasDefaultValue(false);

            builder.HasOne(p => p.CreatedUserInfo)
                .WithMany(p => p.CreateBusinessCards)
                .HasForeignKey(p => p.CreatedBy)
                .HasConstraintName("fk_businessCard_userInfo_createdBy").IsRequired();

            builder.Property(p => p.DateCreated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.LastUpdated)
                .HasColumnType(DbDataType.DateTime);
            builder.HasOne(p => p.UpdatedUserInfo)
                .WithMany(p => p.UpdatedBusinessCards)
                .HasForeignKey(p => p.UpdatedBy)
                .HasConstraintName("fk_businessCard_userInfo_updatedBy");
        }
    }
}