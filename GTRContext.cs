using Microsoft.EntityFrameworkCore;
using TNRD.Zeepkist.GTR.Database.Models;
using Version = TNRD.Zeepkist.GTR.Database.Models.Version;

namespace TNRD.Zeepkist.GTR.Database;

public partial class GTRContext : DbContext
{
    public GTRContext(DbContextOptions<GTRContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auth> Auths { get; set; }

    public virtual DbSet<Favorite> Favorites { get; set; }

    public virtual DbSet<LevelPoints> LevelPoints { get; set; }

    public virtual DbSet<Media> Media { get; set; }

    public virtual DbSet<PersonalBest> PersonalBests { get; set; }

    public virtual DbSet<Record> Records { get; set; }

    public virtual DbSet<Stat> Stats { get; set; }

    public virtual DbSet<Upvote> Upvotes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<Vote> Votes { get; set; }

    public virtual DbSet<WorldRecord> WorldRecords { get; set; }

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

            entity.ToTable("auth", tb => tb.HasComment("@omit"));

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Auths)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("auth_user_foreign");
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("favorites_pkey");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Favorites)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("favorites_user_foreign");
        });

        modelBuilder.Entity<LevelPoints>(entity => { entity.HasKey(e => e.Id).HasName("level_points_pkey"); });

        modelBuilder.Entity<Media>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("media_pkey");

            entity.HasOne(d => d.RecordNavigation).WithMany(p => p.Media)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("media_record_fkey");
        });

        modelBuilder.Entity<PersonalBest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personal_bests_pkey");

            entity.HasOne(d => d.RecordNavigation).WithMany(p => p.PersonalBests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personal_bests_record_fkey");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.PersonalBests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personal_bests_user_fkey");
        });

        modelBuilder.Entity<Record>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("records_pkey");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Records)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("records_user_foreign");
        });

        modelBuilder.Entity<Stat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stats_pkey");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Stats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_id");
        });

        modelBuilder.Entity<Upvote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("upvotes_pkey");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Upvotes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("upvotes_user_foreign");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.Property(e => e.Banned).HasDefaultValueSql("false");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("versions_pkey");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
        });

        modelBuilder.Entity<Vote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("votes_pkey");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.Votes)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("votes_user_foreign");
        });

        modelBuilder.Entity<WorldRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("world_records_pkey");

            entity.HasOne(d => d.RecordNavigation).WithMany(p => p.WorldRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("world_records_record_fkey");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.WorldRecordsNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("world_records_user_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
