using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Mapping;

public partial class LevelItemMap
    : IEntityTypeConfiguration<Zeepkist.GTR.Database.Data.Entities.LevelItem>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Zeepkist.GTR.Database.Data.Entities.LevelItem> builder)
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

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasColumnType("text");

        builder.Property(t => t.ImageUrl)
            .IsRequired()
            .HasColumnName("image_url")
            .HasColumnType("text");

        builder.Property(t => t.CreatedAt)
            .IsRequired()
            .HasColumnName("created_at")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.UpdatedAt)
            .IsRequired()
            .HasColumnName("updated_at")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.WorkshopId)
            .IsRequired()
            .HasColumnName("workshop_id")
            .HasColumnType("numeric");

        builder.Property(t => t.AuthorId)
            .IsRequired()
            .HasColumnName("author_id")
            .HasColumnType("numeric");

        builder.Property(t => t.FileHash)
            .IsRequired()
            .HasColumnName("file_hash")
            .HasColumnType("text");

        builder.Property(t => t.FileUrl)
            .IsRequired()
            .HasColumnName("file_url")
            .HasColumnType("text");

        builder.Property(t => t.FileAuthor)
            .IsRequired()
            .HasColumnName("file_author")
            .HasColumnType("text");

        builder.Property(t => t.FileUid)
            .IsRequired()
            .HasColumnName("file_uid")
            .HasColumnType("text");

        builder.Property(t => t.ReplacedBy)
            .HasColumnName("replaced_by")
            .HasColumnType("integer");

        builder.Property(t => t.Deleted)
            .IsRequired()
            .HasColumnName("deleted")
            .HasColumnType("boolean");

        builder.Property(t => t.MetadataId)
            .IsRequired()
            .HasColumnName("metadata_id")
            .HasColumnType("integer");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        // relationships
        builder.HasOne(t => t.MetadataLevelMetadata)
            .WithMany(t => t.MetadataLevelItems)
            .HasForeignKey(d => d.MetadataId)
            .HasConstraintName("levels_metadata_id_fkey");

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
        public const string Name = "name";
        public const string ImageUrl = "image_url";
        public const string CreatedAt = "created_at";
        public const string UpdatedAt = "updated_at";
        public const string WorkshopId = "workshop_id";
        public const string AuthorId = "author_id";
        public const string FileHash = "file_hash";
        public const string FileUrl = "file_url";
        public const string FileAuthor = "file_author";
        public const string FileUid = "file_uid";
        public const string ReplacedBy = "replaced_by";
        public const string Deleted = "deleted";
        public const string MetadataId = "metadata_id";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
