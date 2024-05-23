using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Domain.Models;

public partial class VersionUpdateModel
{
    #region Generated Properties
    public int Id { get; set; }

    public string? Minimum { get; set; }

    public string? Latest { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    #endregion

}
