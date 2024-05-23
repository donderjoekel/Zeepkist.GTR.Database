using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Mapping;

public partial class PersonalBestGlobalMap
    : IEntityTypeConfiguration<Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("personal_best_global", "public");

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
        builder.HasOne(t => t.Record1)
            .WithMany(t => t.PersonalBestGlobals)
            .HasForeignKey(d => d.Record)
            .HasConstraintName("personal_bests_global_record_fkey");

        builder.HasOne(t => t.User1)
            .WithMany(t => t.PersonalBestGlobals)
            .HasForeignKey(d => d.User)
            .HasConstraintName("personal_bests_global_user_fkey");

        builder.HasOne(t => t.LevelLevelMetadata)
            .WithMany(t => t.LevelPersonalBestGlobals)
            .HasForeignKey(d => d.Level)
            .HasConstraintName("personal_bests_global_level_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "personal_best_global";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string Record = "record";
        public const string User = "user";
        public const string Level = "level";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
