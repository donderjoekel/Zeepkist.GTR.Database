using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class Level
    : IEntity
{
    public Level()
    {
        #region Generated Constructor
        Favorites = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite>();
        LevelItems = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem>();
        LevelMetadata = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata>();
        LevelPoints = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints>();
        PersonalBestGlobals = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>();
        Records = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Record>();
        Upvotes = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote>();
        Votes = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Vote>();
        WorldRecordGlobals = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal>();
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }
    public string Hash { get; set; } = null!;
    public global::System.DateTimeOffset DateCreated { get; set; }
    public global::System.DateTimeOffset? DateUpdated { get; set; }
    #endregion

    #region Generated Relationships
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite> Favorites { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem> LevelItems { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata> LevelMetadata { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints> LevelPoints { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal> PersonalBestGlobals { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Record> Records { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> Upvotes { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Vote> Votes { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal> WorldRecordGlobals { get; set; }
    #endregion

}
