using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class LevelMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.Level>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.Level> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("level", "public");

        // key
        builder.HasKey(t => t.Id);

        // unique
        builder.HasIndex(t => t.Hash).IsUnique();

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Hash)
            .IsRequired()
            .HasColumnName("hash")
            .HasColumnType("text");

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
        public const string Name = "level";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string Hash = "hash";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
