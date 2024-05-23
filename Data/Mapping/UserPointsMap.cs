using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class UserPointsMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("user_points", "public");

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

        builder.Property(t => t.Points)
            .IsRequired()
            .HasColumnName("points")
            .HasColumnType("integer");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.Rank)
            .IsRequired()
            .HasColumnName("rank")
            .HasColumnType("integer")
            .HasDefaultValue(0);

        builder.Property(t => t.WorldRecords)
            .HasColumnName("world_records")
            .HasColumnType("integer")
            .HasDefaultValue(0);

        // relationships
        builder.HasOne(t => t.User1)
            .WithMany(t => t.UserPoints)
            .HasForeignKey(d => d.User)
            .HasConstraintName("player_points_user_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "user_points";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string User = "user";
        public const string Points = "points";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
        public const string Rank = "rank";
        public const string WorldRecords = "world_records";
    }
    #endregion
}
