using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Mapping;

public partial class AuthMap
    : IEntityTypeConfiguration<TNRD.Zeepkist.GTR.Database.Data.Entities.Auth>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TNRD.Zeepkist.GTR.Database.Data.Entities.Auth> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("auth", "public");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("integer")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.User)
            .HasColumnName("user")
            .HasColumnType("integer");

        builder.Property(t => t.AccessToken)
            .HasColumnName("access_token")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.AccessTokenExpiry)
            .HasColumnName("access_token_expiry")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.RefreshToken)
            .HasColumnName("refresh_token")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.RefreshTokenExpiry)
            .HasColumnName("refresh_token_expiry")
            .HasColumnType("character varying(255)")
            .HasMaxLength(255);

        builder.Property(t => t.Type)
            .HasColumnName("type")
            .HasColumnType("integer");

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
        builder.HasOne(t => t.User1)
            .WithMany(t => t.Auths)
            .HasForeignKey(d => d.User)
            .HasConstraintName("auth_user_foreign");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "public";
        public const string Name = "auth";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string User = "user";
        public const string AccessToken = "access_token";
        public const string AccessTokenExpiry = "access_token_expiry";
        public const string RefreshToken = "refresh_token";
        public const string RefreshTokenExpiry = "refresh_token_expiry";
        public const string Type = "type";
        public const string DateCreated = "date_created";
        public const string DateUpdated = "date_updated";
    }
    #endregion
}
