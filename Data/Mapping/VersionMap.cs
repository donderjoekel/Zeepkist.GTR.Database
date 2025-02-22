using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class VersionMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.Version>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.Version> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("version", "public");

        // key
        builder.HasKey(t => t.Id);

        // unique

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Minimum)
            .HasColumnName("minimum")
            .HasColumnType("text");

        builder.Property(t => t.Latest)
            .HasColumnName("latest")
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
        public const string Name = "version";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string Minimum = "minimum";
        public const string Latest = "latest";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
