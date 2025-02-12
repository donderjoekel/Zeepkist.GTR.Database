using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class Version
    : IEntity
{
    public Version()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }
    public string? Minimum { get; set; }
    public string? Latest { get; set; }
    public global::System.DateTimeOffset DateCreated { get; set; }
    public global::System.DateTimeOffset? DateUpdated { get; set; }
    #endregion

    #region Generated Relationships
    #endregion

}
