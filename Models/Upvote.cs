using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("upvotes")]
public partial class Upvote : ModelBase
{
    [Column("user")] public int User { get; set; }

    [Column("level")] public string Level { get; set; } = null!;

    [ForeignKey("User")]
    [InverseProperty("Upvotes")]
    public virtual User? UserNavigation { get; set; } = null!;
}
