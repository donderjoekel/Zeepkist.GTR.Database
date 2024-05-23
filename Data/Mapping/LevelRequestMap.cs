using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Mapping;

public partial class LevelRequestMap
    : IEntityTypeConfiguration<Zeepkist.GTR.Database.Data.Entities.LevelRequest>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Zeepkist.GTR.Database.Data.Entities.LevelRequest> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("level_request", "public");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.WorkshopId)
            .IsRequired()
            .HasColumnName("workshop_id")
            .HasColumnType("numeric");

        builder.Property(t => t.Uid)
            .HasColumnName("uid")
            .HasColumnType("text");

        builder.Property(t => t.Hash)
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
        public const string Name = "level_request";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string WorkshopId = "workshop_id";
        public const string Uid = "uid";
        public const string Hash = "hash";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
