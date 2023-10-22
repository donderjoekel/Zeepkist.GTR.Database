using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("player_points")]
public class PlayerPoints : ModelBase
{
    [Column("user")] public int User { get; set; }
    [Column("points")] public int Points { get; set; }

    [ForeignKey("User")]
    [InverseProperty("PlayerPoints")]
    public virtual User? UserNavigation { get; set; } = null!;
}
