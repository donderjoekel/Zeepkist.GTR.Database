using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Data.Entities;

public partial class WorldRecordWeekly
{
    public WorldRecordWeekly()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public int Record { get; set; }

    public int Level { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int Year { get; set; }

    public int Week { get; set; }

    #endregion

    #region Generated Relationships
    public virtual LevelMetadata LevelLevelMetadata { get; set; } = null!;

    public virtual Record Record1 { get; set; } = null!;

    #endregion

}
