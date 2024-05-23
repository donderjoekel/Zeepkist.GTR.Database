using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Domain.Models;

public partial class PersonalBestGlobalCreateModel
{
    #region Generated Properties
    public int Id { get; set; }

    public int Record { get; set; }

    public int User { get; set; }

    public int Level { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    #endregion

}
