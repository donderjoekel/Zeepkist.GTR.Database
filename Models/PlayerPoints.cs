using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("player_points")]
public class PlayerPoints : ModelBase
{
    [Column("user")]
    [Attr(PublicName = "userId")]
    public int User { get; set; }

    [Column("points")] [Attr] public int Points { get; set; }
    [Column("rank")] [Attr] public int Rank { get; set; }
    [Column("world_records")] [Attr] public int WorldRecords { get; set; }

    [ForeignKey("User")]
    [InverseProperty("PlayerPoints")]
    [HasOne(PublicName = "user")]
    public virtual User? UserNavigation { get; set; } = null!;
}
