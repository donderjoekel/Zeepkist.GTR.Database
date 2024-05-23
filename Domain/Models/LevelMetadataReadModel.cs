using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Domain.Models;

public partial class LevelMetadataReadModel
{
    #region Generated Properties
    public string Hash { get; set; } = null!;

    public bool Valid { get; set; }

    public int Checkpoints { get; set; }

    public string Blocks { get; set; } = null!;

    public float Validation { get; set; }

    public float Gold { get; set; }

    public float Silver { get; set; }

    public float Bronze { get; set; }

    public int Ground { get; set; }

    public int Skybox { get; set; }

    public int Id { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    #endregion

}
