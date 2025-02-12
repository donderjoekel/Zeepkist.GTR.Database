using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class LevelItem
    : IEntity
{
    public LevelItem()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }
    public int IdLevel { get; set; }
    public decimal WorkshopId { get; set; }
    public decimal AuthorId { get; set; }
    public string Name { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string FileAuthor { get; set; } = null!;
    public string FileUid { get; set; } = null!;
    public float ValidationTimeAuthor { get; set; }
    public float ValidationTimeGold { get; set; }
    public float ValidationTimeSilver { get; set; }
    public float ValidationTimeBronze { get; set; }
    public bool Deleted { get; set; }
    public global::System.DateTimeOffset CreatedAt { get; set; }
    public global::System.DateTimeOffset UpdatedAt { get; set; }
    public global::System.DateTimeOffset DateCreated { get; set; }
    public global::System.DateTimeOffset? DateUpdated { get; set; }
    #endregion

    #region Generated Relationships
    public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.Level Level { get; set; } = null!;
    #endregion

}
