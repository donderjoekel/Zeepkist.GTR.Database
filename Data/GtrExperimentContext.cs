using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TNRD.Zeepkist.GTR.Database.Data;

public partial class GtrExperimentContext : DbContext
{
    public GtrExperimentContext(DbContextOptions<GtrExperimentContext> options)
        : base(options)
    {
    }

    #region Generated Properties
    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Auth> Auths { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite> Favorites { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem> LevelItems { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata> LevelMetadata { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints> LevelPoints { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelRequest> LevelRequests { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Level> Levels { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal> PersonalBestGlobals { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia> RecordMedia { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Record> Records { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> Upvotes { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints> UserPoints { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.User> Users { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Version> Versions { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Vote> Votes { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal> WorldRecordGlobals { get; set; } = null!;

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Generated Configuration
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.AuthMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.FavoriteMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.LevelItemMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.LevelMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.LevelMetadataMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.LevelPointsMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.LevelRequestMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.PersonalBestGlobalMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.RecordMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.RecordMediaMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.UpvoteMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.UserMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.UserPointsMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.VersionMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.VoteMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.WorldRecordGlobalMap());
        #endregion
    }
}
