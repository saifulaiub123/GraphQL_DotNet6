using GraphQl_HotChochlete.Constant;
using GraphQl_HotChochlete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQl_HotChochlete.Configuration
{
    public class StakeholderInfoDbConfiguration : IEntityTypeConfiguration<StakeholderInfo>
    {
        public void Configure(EntityTypeBuilder<StakeholderInfo> builder)
        {
            builder.ToTable(TableNames.StakeholderInfo);
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(250)
                .IsRequired();
            builder.Property(p => p.MobileNumber)
                .HasMaxLength(16)
                .IsRequired();
            builder.Property(p => p.OtherNumber)
                .HasMaxLength(16);
            builder.Property(p => p.PoliticalInterest)
                .HasMaxLength(250);
            builder.Property(p => p.PoliticalInfluence)
                .HasMaxLength(250);
            builder.Property(p => p.Batch)
                .HasMaxLength(250);
            builder.Property(p => p.CommunicationBy)
                .HasMaxLength(250)
                .IsRequired();
            builder.Property(p => p.OverallRelationType)
                .HasMaxLength(250);
            builder.Property(p => p.Remarks);
            builder.Property(p => p.OtherInformation);
            builder.Property(p => p.ProfileImage);
            builder.Property(p => p.BusinessCard);
            builder.Property(p => p.Email)
                .HasMaxLength(150);
            builder.Property(p => p.IsPrivate)
                .HasDefaultValue(false);

            builder.Property(p => p.CreatedBy)
            .IsRequired();
            builder.Property(p => p.DateCreated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.LastUpdated)
                .HasColumnType(DbDataType.DateTime);
            builder.Property(p => p.UpdatedBy);

            builder.HasOne(p => p.CreatedUserInfo)
                .WithMany(p => p.CreatedStakeholderInfo)
                .HasForeignKey(p => p.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.UpdatedUserInfo)
                .WithMany(p => p.UpdatedStakeholderInfo)
                .HasForeignKey(p => p.UpdatedBy);

        }
    }
}
