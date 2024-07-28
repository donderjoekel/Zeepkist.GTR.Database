using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class LevelMetadataMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("level_metadata", "public");

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

        builder.Property(t => t.AmountCheckpoints)
            .IsRequired()
            .HasColumnName("amount_checkpoints")
            .HasColumnType("integer");

        builder.Property(t => t.AmountFinishes)
            .IsRequired()
            .HasColumnName("amount_finishes")
            .HasColumnType("integer");

        builder.Property(t => t.AmountBlocks)
            .IsRequired()
            .HasColumnName("amount_blocks")
            .HasColumnType("integer");

        builder.Property(t => t.TypeGround)
            .IsRequired()
            .HasColumnName("type_ground")
            .HasColumnType("integer");

        builder.Property(t => t.TypeSkybox)
            .IsRequired()
            .HasColumnName("type_skybox")
            .HasColumnType("integer");

        builder.Property(t => t.Blocks)
            .IsRequired()
            .HasColumnName("blocks")
            .HasColumnType("jsonb");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        // relationships
        builder.HasOne(t => t.Level)
            .WithMany(t => t.LevelMetadata)
            .HasForeignKey(d => d.IdLevel)
            .HasConstraintName("level_metadata_id_level_fkey");

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
        public const string Id = "id";
        public const string IdLevel = "id_level";
        public const string AmountCheckpoints = "amount_checkpoints";
        public const string AmountFinishes = "amount_finishes";
        public const string AmountBlocks = "amount_blocks";
        public const string TypeGround = "type_ground";
        public const string TypeSkybox = "type_skybox";
        public const string Blocks = "blocks";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
