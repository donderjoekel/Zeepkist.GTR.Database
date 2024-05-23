using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Mapping;

public partial class LevelMetadataMap
    : IEntityTypeConfiguration<Zeepkist.GTR.Database.Data.Entities.LevelMetadata>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Zeepkist.GTR.Database.Data.Entities.LevelMetadata> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("level_metadata", "public");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Hash)
            .IsRequired()
            .HasColumnName("hash")
            .HasColumnType("text");

        builder.Property(t => t.Valid)
            .IsRequired()
            .HasColumnName("valid")
            .HasColumnType("boolean");

        builder.Property(t => t.Checkpoints)
            .IsRequired()
            .HasColumnName("checkpoints")
            .HasColumnType("integer");

        builder.Property(t => t.Blocks)
            .IsRequired()
            .HasColumnName("blocks")
            .HasColumnType("text");

        builder.Property(t => t.Validation)
            .IsRequired()
            .HasColumnName("validation")
            .HasColumnType("real");

        builder.Property(t => t.Gold)
            .IsRequired()
            .HasColumnName("gold")
            .HasColumnType("real");

        builder.Property(t => t.Silver)
            .IsRequired()
            .HasColumnName("silver")
            .HasColumnType("real");

        builder.Property(t => t.Bronze)
            .IsRequired()
            .HasColumnName("bronze")
            .HasColumnType("real");

        builder.Property(t => t.Ground)
            .IsRequired()
            .HasColumnName("ground")
            .HasColumnType("integer");

        builder.Property(t => t.Skybox)
            .IsRequired()
            .HasColumnName("skybox")
            .HasColumnType("integer");

        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        // relationships
        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "level_metadata";
    }

    public readonly struct Columns
    {
        public const string Hash = "hash";
        public const string Valid = "valid";
        public const string Checkpoints = "checkpoints";
        public const string Blocks = "blocks";
        public const string Validation = "validation";
        public const string Gold = "gold";
        public const string Silver = "silver";
        public const string Bronze = "bronze";
        public const string Ground = "ground";
        public const string Skybox = "skybox";
        public const string Id = "id";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
