using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("metadata")]
[NoResource]
public partial class Metadata
{
    [Column("hash")]
    public string Hash { get; set; } = null!;

    [Column("valid")]
    public bool Valid { get; set; }

    [Column("checkpoints")]
    public int Checkpoints { get; set; }

    [Column("blocks")]
    public string Blocks { get; set; } = null!;

    [Column("validation")]
    public float Validation { get; set; }

    [Column("gold")]
    public float Gold { get; set; }

    [Column("silver")]
    public float Silver { get; set; }

    [Column("bronze")]
    public float Bronze { get; set; }

    [Column("ground")]
    public int Ground { get; set; }

    [Column("skybox")]
    public int Skybox { get; set; }

    [Key]
    [Column("id")]
    public int Id { get; set; }

    [InverseProperty("Metadata")]
    public virtual ICollection<Level> Levels { get; set; } = new List<Level>();
}
