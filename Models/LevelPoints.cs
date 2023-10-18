using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("level_points")]
public class LevelPoints : ModelBase
{
    [Column("level")] public string Level { get; set; } = null!;
    [Column("points")] public int Points { get; set; }
}
