using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Mapping;

public partial class WorldRecordGlobalMap
    : IEntityTypeConfiguration<Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("world_record_global", "public");

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

        // relationships
        builder.HasOne(t => t.Record1)
            .WithMany(t => t.WorldRecordGlobals)
            .HasForeignKey(d => d.Record)
            .HasConstraintName("world_records_global_record_fkey");

        builder.HasOne(t => t.LevelLevelMetadata)
            .WithMany(t => t.LevelWorldRecordGlobals)
            .HasForeignKey(d => d.Level)
            .HasConstraintName("world_records_global_level_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "world_record_global";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string Record = "record";
        public const string Level = "level";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
