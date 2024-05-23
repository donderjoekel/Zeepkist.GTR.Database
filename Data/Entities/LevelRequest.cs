using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Data.Entities;

public partial class LevelRequest
{
    public LevelRequest()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public decimal WorkshopId { get; set; }

    public string? Uid { get; set; }

    public string? Hash { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
