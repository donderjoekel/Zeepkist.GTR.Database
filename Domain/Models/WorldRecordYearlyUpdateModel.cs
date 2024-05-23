using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Domain.Models;

public partial class WorldRecordYearlyUpdateModel
{
    #region Generated Properties
    public int Id { get; set; }

    public int Record { get; set; }

    public int Level { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int Year { get; set; }

    #endregion

}
