using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class Favorite
    : IEntity
{
    public Favorite()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }
    public int IdUser { get; set; }
    public global::System.DateTimeOffset DateCreated { get; set; }
    public global::System.DateTimeOffset? DateUpdated { get; set; }
    public int IdLevel { get; set; }
    #endregion

    #region Generated Relationships
    public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.Level Level { get; set; } = null!;
    public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.User User { get; set; } = null!;
    #endregion

}
