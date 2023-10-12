using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("versions")]
public partial class Version : ModelBase
{
    [Column("minimum")] public string? Minimum { get; set; }

    [Column("latest")] public string? Latest { get; set; }
}
