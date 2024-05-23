using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class RecordMedia
{
    public RecordMedia()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public int Record { get; set; }

    public string GhostUrl { get; set; } = null!;

    public string ScreenshotUrl { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Record Record1 { get; set; } = null!;

    #endregion

}
