using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("votes")]
public partial class Vote : ModelBase
{
    [Column("user")] public int User { get; set; }

    [Column("score")] public int Score { get; set; }

    [Column("level")] public string Level { get; set; } = null!;

    [ForeignKey("User")]
    [InverseProperty("Votes")]
    public virtual User? UserNavigation { get; set; } = null!;
}
