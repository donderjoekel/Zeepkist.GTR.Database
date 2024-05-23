using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class StatsWeekly
{
    public StatsWeekly()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public int User { get; set; }

    public int Level { get; set; }

    public string Data { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int Year { get; set; }

    public int Week { get; set; }

    #endregion

    #region Generated Relationships
    public virtual LevelMetadata LevelLevelMetadata { get; set; } = null!;

    public virtual User User1 { get; set; } = null!;

    #endregion

}
