using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class RecordMedia
    : IEntity
{
    public RecordMedia()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }
    public int IdRecord { get; set; }
    public string? GhostUrl { get; set; }
    public global::System.DateTimeOffset DateCreated { get; set; }
    public global::System.DateTimeOffset? DateUpdated { get; set; }
    #endregion

    #region Generated Relationships
    public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.Record Record { get; set; } = null!;
    #endregion

}
