using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class LevelItemMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("level_item", "public");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.IdLevel)
            .IsRequired()
            .HasColumnName("id_level")
            .HasColumnType("integer");

        builder.Property(t => t.WorkshopId)
            .IsRequired()
            .HasColumnName("workshop_id")
            .HasColumnType("numeric");

        builder.Property(t => t.AuthorId)
            .IsRequired()
            .HasColumnName("author_id")
            .HasColumnType("numeric");

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasColumnType("text");

        builder.Property(t => t.ImageUrl)
            .IsRequired()
            .HasColumnName("image_url")
            .HasColumnType("text");

        builder.Property(t => t.FileAuthor)
            .IsRequired()
            .HasColumnName("file_author")
            .HasColumnType("text");

        builder.Property(t => t.FileUid)
            .IsRequired()
            .HasColumnName("file_uid")
            .HasColumnType("text");

        builder.Property(t => t.ValidationTimeAuthor)
            .IsRequired()
            .HasColumnName("validation_time_author")
            .HasColumnType("real");

        builder.Property(t => t.ValidationTimeGold)
            .IsRequired()
            .HasColumnName("validation_time_gold")
            .HasColumnType("real");

        builder.Property(t => t.ValidationTimeSilver)
            .IsRequired()
            .HasColumnName("validation_time_silver")
            .HasColumnType("real");

        builder.Property(t => t.ValidationTimeBronze)
            .IsRequired()
            .HasColumnName("validation_time_bronze")
            .HasColumnType("real");

        builder.Property(t => t.Deleted)
            .IsRequired()
            .HasColumnName("deleted")
            .HasColumnType("boolean");

        builder.Property(t => t.CreatedAt)
            .IsRequired()
            .HasColumnName("created_at")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.UpdatedAt)
            .IsRequired()
            .HasColumnName("updated_at")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        // relationships
        builder.HasOne(t => t.Level)
            .WithMany(t => t.LevelItems)
            .HasForeignKey(d => d.IdLevel)
            .HasConstraintName("level_item_id_level_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "level_item";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string IdLevel = "id_level";
        public const string WorkshopId = "workshop_id";
        public const string AuthorId = "author_id";
        public const string Name = "name";
        public const string ImageUrl = "image_url";
        public const string FileAuthor = "file_author";
        public const string FileUid = "file_uid";
        public const string ValidationTimeAuthor = "validation_time_author";
        public const string ValidationTimeGold = "validation_time_gold";
        public const string ValidationTimeSilver = "validation_time_silver";
        public const string ValidationTimeBronze = "validation_time_bronze";
        public const string Deleted = "deleted";
        public const string CreatedAt = "created_at";
        public const string UpdatedAt = "updated_at";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
