using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TNRD.Zeepkist.GTR.Database.Data;

public partial class GtarrContext : DbContext
{
    public GtarrContext(DbContextOptions<GtarrContext> options)
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

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily> PersonalBestDailies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal> PersonalBestGlobals { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly> PersonalBestMonthlies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestQuarterly> PersonalBestQuarterlies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> PersonalBestWeeklies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly> PersonalBestYearlies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia> RecordMedia { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Record> Records { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsDaily> StatsDailies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsGlobal> StatsGlobals { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsMonthly> StatsMonthlies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsQuarterly> StatsQuarterlies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsWeekly> StatsWeeklies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsYearly> StatsYearlies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> Upvotes { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints> UserPoints { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.User> Users { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Version> Versions { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily> WorldRecordDailies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal> WorldRecordGlobals { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly> WorldRecordMonthlies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordQuarterly> WorldRecordQuarterlies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly> WorldRecordWeeklies { get; set; } = null!;

    public virtual DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly> WorldRecordYearlies { get; set; } = null!;

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
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.PersonalBestDailyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.PersonalBestGlobalMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.PersonalBestMonthlyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.PersonalBestQuarterlyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.PersonalBestWeeklyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.PersonalBestYearlyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.RecordMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.RecordMediaMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.StatsDailyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.StatsGlobalMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.StatsMonthlyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.StatsQuarterlyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.StatsWeeklyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.StatsYearlyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.UpvoteMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.UserMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.UserPointsMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.VersionMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.WorldRecordDailyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.WorldRecordGlobalMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.WorldRecordMonthlyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.WorldRecordQuarterlyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.WorldRecordWeeklyMap());
        modelBuilder.ApplyConfiguration(new TNRD.Zeepkist.GTR.Database.Data.Mapping.WorldRecordYearlyMap());
        #endregion
    }
}
