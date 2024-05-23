using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class LevelMetadata
{
    public LevelMetadata()
    {
        #region Generated Constructor
        LevelFavorites = new HashSet<Favorite>();
        LevelLevelPoints = new HashSet<LevelPoints>();
        LevelPersonalBestDailies = new HashSet<PersonalBestDaily>();
        LevelPersonalBestGlobals = new HashSet<PersonalBestGlobal>();
        LevelPersonalBestMonthlies = new HashSet<PersonalBestMonthly>();
        LevelPersonalBestWeeklies = new HashSet<PersonalBestWeekly>();
        LevelPersonalBestYearlies = new HashSet<PersonalBestYearly>();
        LevelRecords = new HashSet<Record>();
        LevelStatsDailies = new HashSet<StatsDaily>();
        LevelStatsGlobals = new HashSet<StatsGlobal>();
        LevelStatsMonthlies = new HashSet<StatsMonthly>();
        LevelStatsWeeklies = new HashSet<StatsWeekly>();
        LevelStatsYearlies = new HashSet<StatsYearly>();
        LevelUpvotes = new HashSet<Upvote>();
        LevelWorldRecordDailies = new HashSet<WorldRecordDaily>();
        LevelWorldRecordGlobals = new HashSet<WorldRecordGlobal>();
        LevelWorldRecordMonthlies = new HashSet<WorldRecordMonthly>();
        LevelWorldRecordWeeklies = new HashSet<WorldRecordWeekly>();
        LevelWorldRecordYearlies = new HashSet<WorldRecordYearly>();
        MetadataLevelItems = new HashSet<LevelItem>();
        #endregion
    }

    #region Generated Properties
    public string Hash { get; set; } = null!;

    public bool Valid { get; set; }

    public int Checkpoints { get; set; }

    public string Blocks { get; set; } = null!;

    public float Validation { get; set; }

    public float Gold { get; set; }

    public float Silver { get; set; }

    public float Bronze { get; set; }

    public int Ground { get; set; }

    public int Skybox { get; set; }

    public int Id { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<Favorite> LevelFavorites { get; set; }

    public virtual ICollection<LevelPoints> LevelLevelPoints { get; set; }

    public virtual ICollection<PersonalBestDaily> LevelPersonalBestDailies { get; set; }

    public virtual ICollection<PersonalBestGlobal> LevelPersonalBestGlobals { get; set; }

    public virtual ICollection<PersonalBestMonthly> LevelPersonalBestMonthlies { get; set; }

    public virtual ICollection<PersonalBestWeekly> LevelPersonalBestWeeklies { get; set; }

    public virtual ICollection<PersonalBestYearly> LevelPersonalBestYearlies { get; set; }

    public virtual ICollection<Record> LevelRecords { get; set; }

    public virtual ICollection<StatsDaily> LevelStatsDailies { get; set; }

    public virtual ICollection<StatsGlobal> LevelStatsGlobals { get; set; }

    public virtual ICollection<StatsMonthly> LevelStatsMonthlies { get; set; }

    public virtual ICollection<StatsWeekly> LevelStatsWeeklies { get; set; }

    public virtual ICollection<StatsYearly> LevelStatsYearlies { get; set; }

    public virtual ICollection<Upvote> LevelUpvotes { get; set; }

    public virtual ICollection<WorldRecordDaily> LevelWorldRecordDailies { get; set; }

    public virtual ICollection<WorldRecordGlobal> LevelWorldRecordGlobals { get; set; }

    public virtual ICollection<WorldRecordMonthly> LevelWorldRecordMonthlies { get; set; }

    public virtual ICollection<WorldRecordWeekly> LevelWorldRecordWeeklies { get; set; }

    public virtual ICollection<WorldRecordYearly> LevelWorldRecordYearlies { get; set; }

    public virtual ICollection<LevelItem> MetadataLevelItems { get; set; }

    #endregion

}
