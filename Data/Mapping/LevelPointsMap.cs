using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class LevelPointsMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("level_points", "public");

        // key
        builder.HasKey(t => t.Id);

        // unique

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Points)
            .IsRequired()
            .HasColumnName("points")
            .HasColumnType("integer");

        builder.Property(t => t.IdLevel)
            .IsRequired()
            .HasColumnName("id_level")
            .HasColumnType("integer");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        // relationships
        builder.HasOne(t => t.Level)
            .WithMany(t => t.LevelPoints)
            .HasForeignKey(d => d.IdLevel)
            .HasConstraintName("level_points_level_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "level_points";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string Points = "points";
        public const string IdLevel = "id_level";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
