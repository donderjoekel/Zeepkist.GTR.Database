using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class Record
    : IEntity
{
    public Record()
    {
        #region Generated Constructor
        PersonalBestGlobals = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>();
        RecordMedia = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia>();
        WorldRecordGlobals = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal>();
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }
    public int IdUser { get; set; }
    public float Time { get; set; }
    public string GameVersion { get; set; } = null!;
    public int IdLevel { get; set; }
    public string ModVersion { get; set; } = null!;
    public global::System.DateTimeOffset DateCreated { get; set; }
    public global::System.DateTimeOffset? DateUpdated { get; set; }
    public global::System.Collections.Generic.List<float>? Splits { get; set; }
    public global::System.Collections.Generic.List<float>? Speeds { get; set; }
    #endregion

    #region Generated Relationships
    public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.Level Level { get; set; } = null!;
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal> PersonalBestGlobals { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia> RecordMedia { get; set; }
    public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.User User { get; set; } = null!;
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal> WorldRecordGlobals { get; set; }
    #endregion

}
