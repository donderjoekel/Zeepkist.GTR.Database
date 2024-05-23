using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Mapping;

public partial class PersonalBestMonthlyMap
    : IEntityTypeConfiguration<Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("personal_best_monthly", "public");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Record)
            .IsRequired()
            .HasColumnName("record")
            .HasColumnType("integer");

        builder.Property(t => t.User)
            .IsRequired()
            .HasColumnName("user")
            .HasColumnType("integer");

        builder.Property(t => t.Level)
            .IsRequired()
            .HasColumnName("level")
            .HasColumnType("integer");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.Year)
            .IsRequired()
            .HasColumnName("year")
            .HasColumnType("integer");

        builder.Property(t => t.Month)
            .IsRequired()
            .HasColumnName("month")
            .HasColumnType("integer");

        // relationships
        builder.HasOne(t => t.Record1)
            .WithMany(t => t.PersonalBestMonthlies)
            .HasForeignKey(d => d.Record)
            .HasConstraintName("personal_bests_monthly_record_fkey");

        builder.HasOne(t => t.User1)
            .WithMany(t => t.PersonalBestMonthlies)
            .HasForeignKey(d => d.User)
            .HasConstraintName("personal_bests_monthly_user_fkey");

        builder.HasOne(t => t.LevelLevelMetadata)
            .WithMany(t => t.LevelPersonalBestMonthlies)
            .HasForeignKey(d => d.Level)
            .HasConstraintName("personal_bests_monthly_level_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "personal_best_monthly";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string Record = "record";
        public const string User = "user";
        public const string Level = "level";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
        public const string Year = "year";
        public const string Month = "month";
    }
    #endregion
}
