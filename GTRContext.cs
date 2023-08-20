using Microsoft.EntityFrameworkCore;
using Npgsql;
using TNRD.Zeepkist.GTR.Database.Models;

namespace TNRD.Zeepkist.GTR.Database;

public partial class GTRContext : DbContext
{
    public GTRContext(DbContextOptions<GTRContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auth> Auths { get; set; }

    public virtual DbSet<Favorite> Favorites { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<Record> Records { get; set; }

    public virtual DbSet<Stat> Stats { get; set; }

    public virtual DbSet<Upvote> Upvotes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vote> Votes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("fuzzystrmatch")
            .HasPostgresExtension("postgis")
            .HasPostgresExtension("tiger", "postgis_tiger_geocoder")
            .HasPostgresExtension("topology", "postgis_topology");

        modelBuilder.Entity<Auth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_pkey");

            entity.ToTable("auth");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessToken)
                .HasMaxLength(255)
                .HasColumnName("access_token");
            entity.Property(e => e.AccessTokenExpiry)
                .HasMaxLength(255)
                .HasColumnName("access_token_expiry");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.DateUpdated).HasColumnName("date_updated");
            entity.Property(e => e.RefreshToken)
                .HasMaxLength(255)
                .HasColumnName("refresh_token");
            entity.Property(e => e.RefreshTokenExpiry)
                .HasMaxLength(255)
                .HasColumnName("refresh_token_expiry");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.User).HasColumnName("user");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Auths)
                .HasForeignKey(d => d.User)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("auth_user_foreign");
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("favorites_pkey");

            entity.ToTable("favorites");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.DateUpdated).HasColumnName("date_updated");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.User).HasColumnName("user");

            entity.HasOne(d => d.LevelNavigation).WithMany(p => p.Favorites)
                .HasForeignKey(d => d.Level)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("favorites_level_foreign");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Favorites)
                .HasForeignKey(d => d.User)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("favorites_user_foreign");
        });

        modelBuilder.Entity<Level>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("levels_pkey");

            entity.ToTable("levels");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(255)
                .HasColumnName("author");
            entity.Property(e => e.Blocked)
                .HasDefaultValueSql("false")
                .HasColumnName("blocked");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.DateUpdated).HasColumnName("date_updated");
            entity.Property(e => e.IsValid)
                .HasDefaultValueSql("true")
                .HasColumnName("is_valid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Points).HasColumnName("points");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.ThumbnailUrl)
                .HasMaxLength(2048)
                .HasColumnName("thumbnail_url");
            entity.Property(e => e.TimeAuthor).HasColumnName("time_author");
            entity.Property(e => e.TimeBronze).HasColumnName("time_bronze");
            entity.Property(e => e.TimeGold).HasColumnName("time_gold");
            entity.Property(e => e.TimeSilver).HasColumnName("time_silver");
            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("uid");
            entity.Property(e => e.Wid)
                .HasMaxLength(255)
                .HasColumnName("wid");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Levels)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("levels_created_by_foreign");
        });

        modelBuilder.Entity<Record>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("records_pkey");

            entity.ToTable("records");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.DateUpdated).HasColumnName("date_updated");
            entity.Property(e => e.GameVersion)
                .HasMaxLength(255)
                .HasColumnName("game_version");
            entity.Property(e => e.GhostUrl)
                .HasMaxLength(255)
                .HasColumnName("ghost_url");
            entity.Property(e => e.IsBest).HasColumnName("is_best");
            entity.Property(e => e.IsValid).HasColumnName("is_valid");
            entity.Property(e => e.IsWr).HasColumnName("is_wr");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.ScreenshotUrl)
                .HasMaxLength(255)
                .HasColumnName("screenshot_url");
            entity.Property(e => e.Splits)
                .HasMaxLength(1024)
                .HasColumnName("splits");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.User).HasColumnName("user");

            entity.HasOne(d => d.LevelNavigation).WithMany(p => p.Records)
                .HasForeignKey(d => d.Level)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("records_level_foreign");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Records)
                .HasForeignKey(d => d.User)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("records_user_foreign");
        });

        modelBuilder.Entity<Stat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stats_pkey");

            entity.ToTable("stats");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.CheckpointsCrossed).HasColumnName("checkpoints_crossed");
            entity.Property(e => e.CrashEye).HasColumnName("crash_eye");
            entity.Property(e => e.CrashGhost).HasColumnName("crash_ghost");
            entity.Property(e => e.CrashRegular).HasColumnName("crash_regular");
            entity.Property(e => e.CrashSticky).HasColumnName("crash_sticky");
            entity.Property(e => e.CrashTotal).HasColumnName("crash_total");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.DateUpdated).HasColumnName("date_updated");
            entity.Property(e => e.DistanceArmsUp).HasColumnName("distance_arms_up");
            entity.Property(e => e.DistanceBraking).HasColumnName("distance_braking");
            entity.Property(e => e.DistanceGrounded).HasColumnName("distance_grounded");
            entity.Property(e => e.DistanceInAir).HasColumnName("distance_in_air");
            entity.Property(e => e.DistanceOnFourWheels).HasColumnName("distance_on_four_wheels");
            entity.Property(e => e.DistanceOnGrass).HasColumnName("distance_on_grass");
            entity.Property(e => e.DistanceOnIce).HasColumnName("distance_on_ice");
            entity.Property(e => e.DistanceOnNoWheels).HasColumnName("distance_on_no_wheels");
            entity.Property(e => e.DistanceOnOneWheel).HasColumnName("distance_on_one_wheel");
            entity.Property(e => e.DistanceOnRegular).HasColumnName("distance_on_regular");
            entity.Property(e => e.DistanceOnThreeWheels).HasColumnName("distance_on_three_wheels");
            entity.Property(e => e.DistanceOnTwoWheels).HasColumnName("distance_on_two_wheels");
            entity.Property(e => e.DistanceRagdoll).HasColumnName("distance_ragdoll");
            entity.Property(e => e.DistanceWithFourWheels).HasColumnName("distance_with_four_wheels");
            entity.Property(e => e.DistanceWithNoWheels).HasColumnName("distance_with_no_wheels");
            entity.Property(e => e.DistanceWithOneWheel).HasColumnName("distance_with_one_wheel");
            entity.Property(e => e.DistanceWithThreeWheels).HasColumnName("distance_with_three_wheels");
            entity.Property(e => e.DistanceWithTwoWheels).HasColumnName("distance_with_two_wheels");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.TimeArmsUp).HasColumnName("time_arms_up");
            entity.Property(e => e.TimeBraking).HasColumnName("time_braking");
            entity.Property(e => e.TimeGrounded).HasColumnName("time_grounded");
            entity.Property(e => e.TimeInAir).HasColumnName("time_in_air");
            entity.Property(e => e.TimeOnFourWheels).HasColumnName("time_on_four_wheels");
            entity.Property(e => e.TimeOnGrass).HasColumnName("time_on_grass");
            entity.Property(e => e.TimeOnIce).HasColumnName("time_on_ice");
            entity.Property(e => e.TimeOnNoWheels).HasColumnName("time_on_no_wheels");
            entity.Property(e => e.TimeOnOneWheel).HasColumnName("time_on_one_wheel");
            entity.Property(e => e.TimeOnRegular).HasColumnName("time_on_regular");
            entity.Property(e => e.TimeOnThreeWheels).HasColumnName("time_on_three_wheels");
            entity.Property(e => e.TimeOnTwoWheels).HasColumnName("time_on_two_wheels");
            entity.Property(e => e.TimeRagdoll).HasColumnName("time_ragdoll");
            entity.Property(e => e.TimeWithFourWheels).HasColumnName("time_with_four_wheels");
            entity.Property(e => e.TimeWithNoWheels).HasColumnName("time_with_no_wheels");
            entity.Property(e => e.TimeWithOneWheel).HasColumnName("time_with_one_wheel");
            entity.Property(e => e.TimeWithThreeWheels).HasColumnName("time_with_three_wheels");
            entity.Property(e => e.TimeWithTwoWheels).HasColumnName("time_with_two_wheels");
            entity.Property(e => e.TimesFinished).HasColumnName("times_finished");
            entity.Property(e => e.TimesStarted).HasColumnName("times_started");
            entity.Property(e => e.User).HasColumnName("user");
            entity.Property(e => e.WheelsBroken).HasColumnName("wheels_broken");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Stats)
                .HasForeignKey(d => d.User)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_id");
        });

        modelBuilder.Entity<Upvote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("upvotes_pkey");

            entity.ToTable("upvotes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.DateUpdated).HasColumnName("date_updated");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.User).HasColumnName("user");

            entity.HasOne(d => d.LevelNavigation).WithMany(p => p.Upvotes)
                .HasForeignKey(d => d.Level)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("upvotes_level_foreign");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Upvotes)
                .HasForeignKey(d => d.User)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("upvotes_user_foreign");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Banned)
                .HasDefaultValueSql("false")
                .HasColumnName("banned");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.DateUpdated).HasColumnName("date_updated");
            entity.Property(e => e.DiscordId)
                .HasMaxLength(255)
                .HasColumnName("discord_id");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.SteamId)
                .HasMaxLength(255)
                .HasColumnName("steam_id");
            entity.Property(e => e.SteamName)
                .HasMaxLength(255)
                .HasColumnName("steam_name");
            entity.Property(e => e.WorldRecords).HasColumnName("world_records");
        });

        modelBuilder.Entity<Vote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("votes_pkey");

            entity.ToTable("votes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.DateUpdated).HasColumnName("date_updated");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.User).HasColumnName("user");

            entity.HasOne(d => d.LevelNavigation).WithMany(p => p.Votes)
                .HasForeignKey(d => d.Level)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("votes_level_foreign");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Votes)
                .HasForeignKey(d => d.User)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("votes_user_foreign");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public int UpdatePersonalBest(int user, int level)
    {
        NpgsqlParameter paramUserId = new("p_user", user);
        NpgsqlParameter paramLevelId = new("p_level", level);
        return Database.ExecuteSqlRaw("SELECT update_pb(@p_user, @p_level)", paramUserId, paramLevelId);
    }

    public int UpdateWorldRecord(int level)
    {
        NpgsqlParameter paramLevelId = new("p_level", level);
        return Database.ExecuteSqlRaw("SELECT update_wr(@p_level)", paramLevelId);
    }
}
