using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Domain.Models;

public partial class FavoriteReadModel
{
    #region Generated Properties
    public int Id { get; set; }

    public int User { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int Level { get; set; }

    #endregion

}
