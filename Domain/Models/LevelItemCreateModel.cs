using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Domain.Models;

public partial class LevelItemCreateModel
{
    #region Generated Properties
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public decimal WorkshopId { get; set; }

    public decimal AuthorId { get; set; }

    public string FileHash { get; set; } = null!;

    public string FileUrl { get; set; } = null!;

    public string FileAuthor { get; set; } = null!;

    public string FileUid { get; set; } = null!;

    public int? ReplacedBy { get; set; }

    public bool Deleted { get; set; }

    public int MetadataId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    #endregion

}
