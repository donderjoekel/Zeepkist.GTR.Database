using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Mapping;

public partial class UserMap
    : IEntityTypeConfiguration<Zeepkist.GTR.Database.Data.Entities.User>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Zeepkist.GTR.Database.Data.Entities.User> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("user", "public");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.SteamId)
            .HasColumnName("steam_id")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.SteamName)
            .HasColumnName("steam_name")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.DiscordId)
            .HasColumnName("discord_id")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.Banned)
            .IsRequired()
            .HasColumnName("banned")
            .HasColumnType("boolean")
            .HasDefaultValue(false);

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("date_created")
            .HasColumnType("timestamp with time zone")
            .HasDefaultValueSql("now()");

        builder.Property(t => t.DateUpdated)
            .IsRequired()
            .HasColumnName("date_updated")
            .HasColumnType("timestamp with time zone")
            .HasDefaultValueSql("now()");

        // relationships
        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "user";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string SteamId = "steam_id";
        public const string SteamName = "steam_name";
        public const string DiscordId = "discord_id";
        public const string Banned = "banned";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
