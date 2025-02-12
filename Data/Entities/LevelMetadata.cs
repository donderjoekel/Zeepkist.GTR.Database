using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class LevelMetadata
    : IEntity
{
    public LevelMetadata()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }
    public int IdLevel { get; set; }
    public int AmountCheckpoints { get; set; }
    public int AmountFinishes { get; set; }
    public int AmountBlocks { get; set; }
    public int TypeGround { get; set; }
    public int TypeSkybox { get; set; }
    public string Blocks { get; set; } = null!;
    public global::System.DateTimeOffset DateCreated { get; set; }
    public global::System.DateTimeOffset? DateUpdated { get; set; }
    #endregion

    #region Generated Relationships
    public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.Level Level { get; set; } = null!;
    #endregion

}
