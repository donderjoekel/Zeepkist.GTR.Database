using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class RecordMediaMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("record_media", "public");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.IdRecord)
            .IsRequired()
            .HasColumnName("id_record")
            .HasColumnType("integer");

        builder.Property(t => t.GhostUrl)
            .HasColumnName("ghost_url")
            .HasColumnType("text");

        builder.Property(t => t.ScreenshotUrl)
            .HasColumnName("screenshot_url")
            .HasColumnType("text");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        // relationships
        builder.HasOne(t => t.Record)
            .WithMany(t => t.RecordMedia)
            .HasForeignKey(d => d.IdRecord)
            .HasConstraintName("media_record_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "record_media";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string IdRecord = "id_record";
        public const string GhostUrl = "ghost_url";
        public const string ScreenshotUrl = "screenshot_url";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
