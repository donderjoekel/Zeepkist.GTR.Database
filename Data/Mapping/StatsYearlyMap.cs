using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class StatsYearlyMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsYearly>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsYearly> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("stats_yearly", "public");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.User)
            .IsRequired()
            .HasColumnName("user")
            .HasColumnType("integer");

        builder.Property(t => t.Level)
            .IsRequired()
            .HasColumnName("level")
            .HasColumnType("integer");

        builder.Property(t => t.Data)
            .IsRequired()
            .HasColumnName("data")
            .HasColumnType("text");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.Year)
            .HasColumnName("year")
            .HasColumnType("integer");

        // relationships
        builder.HasOne(t => t.User1)
            .WithMany(t => t.StatsYearlies)
            .HasForeignKey(d => d.User)
            .HasConstraintName("stats_yearly_user_fkey");

        builder.HasOne(t => t.LevelLevelMetadata)
            .WithMany(t => t.LevelStatsYearlies)
            .HasForeignKey(d => d.Level)
            .HasConstraintName("stats_yearly_level_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "stats_yearly";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string User = "user";
        public const string Level = "level";
        public const string Data = "data";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
        public const string Year = "year";
    }
    #endregion
}
