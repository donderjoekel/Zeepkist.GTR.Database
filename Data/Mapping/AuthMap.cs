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

        builder.Property(t => t.IdUser)
            .HasColumnName("id_user")
            .HasColumnType("integer");

        builder.Property(t => t.AccessToken)
            .HasColumnName("access_token")
            .HasColumnType("text");

        builder.Property(t => t.AccessTokenExpiry)
            .HasColumnName("access_token_expiry")
            .HasColumnType("bigint");

        builder.Property(t => t.RefreshToken)
            .HasColumnName("refresh_token")
            .HasColumnType("text");

        builder.Property(t => t.RefreshTokenExpiry)
            .HasColumnName("refresh_token_expiry")
            .HasColumnType("bigint");

        builder.Property(t => t.Type)
            .HasColumnName("type")
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
            .WithMany(t => t.Auths)
            .HasForeignKey(d => d.IdUser)
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
        public const string IdUser = "id_user";
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
