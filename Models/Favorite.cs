using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("favorites")]
public partial class Favorite : ModelBase
{
    [Column("user")] public int User { get; set; }

    [Column("level")] public string Level { get; set; } = null!;

    [ForeignKey("User")]
    [InverseProperty("Favorites")]
    public virtual User? UserNavigation { get; set; } = null!;
}
