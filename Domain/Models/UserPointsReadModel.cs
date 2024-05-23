using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Domain.Models;

public partial class UserPointsReadModel
{
    #region Generated Properties
    public int Id { get; set; }

    public int User { get; set; }

    public int Points { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int Rank { get; set; }

    public int? WorldRecords { get; set; }

    #endregion

}
