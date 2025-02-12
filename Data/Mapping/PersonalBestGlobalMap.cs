using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class PersonalBestGlobalMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal> builder)
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

        builder.Property(t => t.IdRecord)
            .IsRequired()
            .HasColumnName("id_record")
            .HasColumnType("integer");

        builder.Property(t => t.IdUser)
            .IsRequired()
            .HasColumnName("id_user")
            .HasColumnType("integer");

        builder.Property(t => t.IdLevel)
            .IsRequired()
            .HasColumnName("id_level")
            .HasColumnType("integer");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        // relationships
        builder.HasOne(t => t.Level)
            .WithMany(t => t.PersonalBestGlobals)
            .HasForeignKey(d => d.IdLevel)
            .HasConstraintName("personal_best_global_level_fkey");

        builder.HasOne(t => t.Record)
            .WithMany(t => t.PersonalBestGlobals)
            .HasForeignKey(d => d.IdRecord)
            .HasConstraintName("personal_bests_global_record_fkey");

        builder.HasOne(t => t.User)
            .WithMany(t => t.PersonalBestGlobals)
            .HasForeignKey(d => d.IdUser)
            .HasConstraintName("personal_bests_global_user_fkey");

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
        public const string IdRecord = "id_record";
        public const string IdUser = "id_user";
        public const string IdLevel = "id_level";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
