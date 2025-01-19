using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class VoteMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.Vote>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.Vote> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("vote", "public");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.IdUser)
            .IsRequired()
            .HasColumnName("id_user")
            .HasColumnType("integer");

        builder.Property(t => t.IdLevel)
            .IsRequired()
            .HasColumnName("id_level")
            .HasColumnType("integer");

        builder.Property(t => t.Value)
            .IsRequired()
            .HasColumnName("value")
            .HasColumnType("integer");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        // relationships
        builder.HasOne(t => t.User)
            .WithMany(t => t.Votes)
            .HasForeignKey(d => d.IdUser)
            .HasConstraintName("vote_id_user_fkey");

        builder.HasOne(t => t.Level)
            .WithMany(t => t.Votes)
            .HasForeignKey(d => d.IdLevel)
            .HasConstraintName("vote_id_level_fkey");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "vote";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string IdUser = "id_user";
        public const string IdLevel = "id_level";
        public const string Value = "value";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
