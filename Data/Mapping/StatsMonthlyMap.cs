using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class StatsMonthlyMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsMonthly>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsMonthly> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("stats_monthly", "public");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.IdUser)
            .IsRequired()
            .HasColumnName("id_user")
            .HasColumnType("integer");

        builder.Property(t => t.IdLevel)
            .HasColumnName("id_level")
            .HasColumnType("integer");

        builder.Property(t => t.Key)
            .IsRequired()
            .HasColumnName("key")
            .HasColumnType("text");

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

        builder.Property(t => t.Value)
            .IsRequired()
            .HasColumnName("value")
            .HasColumnType("numeric");

        // relationships
        builder.HasOne(t => t.User)
            .WithMany(t => t.StatsMonthlies)
            .HasForeignKey(d => d.IdUser)
            .HasConstraintName("stats_monthly_user_fkey");

        builder.HasOne(t => t.Level)
            .WithMany(t => t.StatsMonthlies)
            .HasForeignKey(d => d.IdLevel)
            .HasConstraintName("stats_monthly_level_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "stats_monthly";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string IdUser = "id_user";
        public const string IdLevel = "id_level";
        public const string Key = "key";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
        public const string Year = "year";
        public const string Month = "month";
        public const string Value = "value";
    }
    #endregion
}
