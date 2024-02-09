using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("level_points")]
public class LevelPoints : ModelBase
{
    [Column("level")] [Attr] public string Level { get; set; } = null!;
    [Column("points")] [Attr] public int Points { get; set; }
}
