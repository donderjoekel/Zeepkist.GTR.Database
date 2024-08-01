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

        builder.Property(t => t.IdUser)
            .IsRequired()
            .HasColumnName("id_user")
            .HasColumnType("integer");

        builder.Property(t => t.Time)
            .IsRequired()
            .HasColumnName("time")
            .HasColumnType("real");

        builder.Property(t => t.GameVersion)
            .IsRequired()
            .HasColumnName("game_version")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.IsValid)
            .IsRequired()
            .HasColumnName("is_valid")
            .HasColumnType("boolean");

        builder.Property(t => t.IdLevel)
            .IsRequired()
            .HasColumnName("id_level")
            .HasColumnType("integer");

        builder.Property(t => t.ModVersion)
            .IsRequired()
            .HasColumnName("mod_version")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.Splits)
            .HasColumnName("splits")
            .HasColumnType("real[]");

        builder.Property(t => t.Speeds)
            .HasColumnName("speeds")
            .HasColumnType("real[]");

        // relationships
        builder.HasOne(t => t.User)
            .WithMany(t => t.Records)
            .HasForeignKey(d => d.IdUser)
            .HasConstraintName("records_user_foreign");

        builder.HasOne(t => t.Level)
            .WithMany(t => t.Records)
            .HasForeignKey(d => d.IdLevel)
            .HasConstraintName("record_level_fkey");

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
        public const string IdUser = "id_user";
        public const string Time = "time";
        public const string GameVersion = "game_version";
        public const string IsValid = "is_valid";
        public const string IdLevel = "id_level";
        public const string ModVersion = "mod_version";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
        public const string Splits = "splits";
        public const string Speeds = "speeds";
    }
    #endregion
}
