using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Mapping;

public partial class UpvoteMap
    : IEntityTypeConfiguration<Zeepkist.GTR.Database.Data.Entities.Upvote>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Zeepkist.GTR.Database.Data.Entities.Upvote> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("upvote", "public");

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

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        // relationships
        builder.HasOne(t => t.User1)
            .WithMany(t => t.Upvotes)
            .HasForeignKey(d => d.User)
            .HasConstraintName("upvotes_user_foreign");

        builder.HasOne(t => t.LevelLevelMetadata)
            .WithMany(t => t.LevelUpvotes)
            .HasForeignKey(d => d.Level)
            .HasConstraintName("upvotes_level_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "upvote";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string User = "user";
        public const string Level = "level";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
