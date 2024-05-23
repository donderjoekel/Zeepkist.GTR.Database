using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Domain.Models;

public partial class LevelPointsReadModel
{
    #region Generated Properties
    public int Id { get; set; }

    public int Points { get; set; }

    public int Level { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    #endregion

}
