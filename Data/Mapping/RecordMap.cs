using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class RecordMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.Record>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.Record> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("record", "public");

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

        builder.Property(t => t.Time)
            .IsRequired()
            .HasColumnName("time")
            .HasColumnType("real");

        builder.Property(t => t.Splits)
            .HasColumnName("splits")
            .HasColumnType("text");

        builder.Property(t => t.GameVersion)
            .IsRequired()
            .HasColumnName("game_version")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.IsValid)
            .IsRequired()
            .HasColumnName("is_valid")
            .HasColumnType("boolean");

        builder.Property(t => t.Level)
            .IsRequired()
            .HasColumnName("level")
            .HasColumnType("integer");

        builder.Property(t => t.ModVersion)
            .IsRequired()
            .HasColumnName("mod_version")
            .HasColumnType("text");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .IsRequired()
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        // relationships
        builder.HasOne(t => t.User1)
            .WithMany(t => t.Records)
            .HasForeignKey(d => d.User)
            .HasConstraintName("records_user_foreign");

        builder.HasOne(t => t.LevelLevelMetadata)
            .WithMany(t => t.LevelRecords)
            .HasForeignKey(d => d.Level)
            .HasConstraintName("records_level_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "record";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string User = "user";
        public const string Time = "time";
        public const string Splits = "splits";
        public const string GameVersion = "game_version";
        public const string IsValid = "is_valid";
        public const string Level = "level";
        public const string ModVersion = "mod_version";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
