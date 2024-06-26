using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Domain.Models;

public partial class RecordMediaUpdateModel
{
    #region Generated Properties
    public int Id { get; set; }

    public int Record { get; set; }

    public string GhostUrl { get; set; } = null!;

    public string ScreenshotUrl { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    #endregion

}
