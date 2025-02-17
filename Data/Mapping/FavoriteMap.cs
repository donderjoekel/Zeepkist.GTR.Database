using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class FavoriteMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("favorite", "public");

        // key
        builder.HasKey(t => t.Id);

        // unique

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

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.DateUpdated)
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone");

        builder.Property(t => t.IdLevel)
            .IsRequired()
            .HasColumnName("id_level")
            .HasColumnType("integer");

        // relationships
        builder.HasOne(t => t.Level)
            .WithMany(t => t.Favorites)
            .HasForeignKey(d => d.IdLevel)
            .HasConstraintName("favorite_level_fkey");

        builder.HasOne(t => t.User)
            .WithMany(t => t.Favorites)
            .HasForeignKey(d => d.IdUser)
            .HasConstraintName("favorites_user_foreign");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "favorite";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string IdUser = "id_user";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
        public const string IdLevel = "id_level";
    }
    #endregion
}
