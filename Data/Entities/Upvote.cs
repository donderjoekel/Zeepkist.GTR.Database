using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Data.Entities;

public partial class Upvote
{
    public Upvote()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public int User { get; set; }

    public int Level { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    #endregion

    #region Generated Relationships
    public virtual LevelMetadata LevelLevelMetadata { get; set; } = null!;

    public virtual User User1 { get; set; } = null!;

    #endregion

}
