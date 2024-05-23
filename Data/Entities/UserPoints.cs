using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Data.Entities;

public partial class UserPoints
{
    public UserPoints()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public int User { get; set; }

    public int Points { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int Rank { get; set; }

    public int? WorldRecords { get; set; }

    #endregion

    #region Generated Relationships
    public virtual User User1 { get; set; } = null!;

    #endregion

}
