using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Data.Entities;

public partial class Record
{
    public Record()
    {
        #region Generated Constructor
        PersonalBestDailies = new HashSet<PersonalBestDaily>();
        PersonalBestGlobals = new HashSet<PersonalBestGlobal>();
        PersonalBestMonthlies = new HashSet<PersonalBestMonthly>();
        PersonalBestWeeklies = new HashSet<PersonalBestWeekly>();
        PersonalBestYearlies = new HashSet<PersonalBestYearly>();
        RecordMedia = new HashSet<RecordMedia>();
        WorldRecordDailies = new HashSet<WorldRecordDaily>();
        WorldRecordGlobals = new HashSet<WorldRecordGlobal>();
        WorldRecordMonthlies = new HashSet<WorldRecordMonthly>();
        WorldRecordWeeklies = new HashSet<WorldRecordWeekly>();
        WorldRecordYearlies = new HashSet<WorldRecordYearly>();
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public int User { get; set; }

    public float Time { get; set; }

    public string? Splits { get; set; }

    public string GameVersion { get; set; } = null!;

    public bool IsValid { get; set; }

    public int Level { get; set; }

    public string ModVersion { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    #endregion

    #region Generated Relationships
    public virtual LevelMetadata LevelLevelMetadata { get; set; } = null!;

    public virtual ICollection<PersonalBestDaily> PersonalBestDailies { get; set; }

    public virtual ICollection<PersonalBestGlobal> PersonalBestGlobals { get; set; }

    public virtual ICollection<PersonalBestMonthly> PersonalBestMonthlies { get; set; }

    public virtual ICollection<PersonalBestWeekly> PersonalBestWeeklies { get; set; }

    public virtual ICollection<PersonalBestYearly> PersonalBestYearlies { get; set; }

    public virtual ICollection<RecordMedia> RecordMedia { get; set; }

    public virtual User User1 { get; set; } = null!;

    public virtual ICollection<WorldRecordDaily> WorldRecordDailies { get; set; }

    public virtual ICollection<WorldRecordGlobal> WorldRecordGlobals { get; set; }

    public virtual ICollection<WorldRecordMonthly> WorldRecordMonthlies { get; set; }

    public virtual ICollection<WorldRecordWeekly> WorldRecordWeeklies { get; set; }

    public virtual ICollection<WorldRecordYearly> WorldRecordYearlies { get; set; }

    #endregion

}
