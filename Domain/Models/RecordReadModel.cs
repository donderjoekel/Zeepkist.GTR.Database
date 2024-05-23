using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Domain.Models;

public partial class RecordReadModel
{
    #region Generated Properties
    public int Id { get; set; }

    public int User { get; set; }

    public float Time { get; set; }

    public string? Splits { get; set; }

    public string GameVersion { get; set; } = null!;

    public bool IsValid { get; set; }

    public int Level { get; set; }

    public string ModVersion { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    #endregion

}
