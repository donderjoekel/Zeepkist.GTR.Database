using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Domain.Models;

public partial class StatsDailyCreateModel
{
    #region Generated Properties
    public int Id { get; set; }

    public int User { get; set; }

    public int Level { get; set; }

    public string Data { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int Year { get; set; }

    public int Day { get; set; }

    #endregion

}
