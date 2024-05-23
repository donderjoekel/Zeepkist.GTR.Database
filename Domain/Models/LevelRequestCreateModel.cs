using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Domain.Models;

public partial class LevelRequestCreateModel
{
    #region Generated Properties
    public int Id { get; set; }

    public decimal WorkshopId { get; set; }

    public string? Uid { get; set; }

    public string? Hash { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    #endregion

}
