using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("votes")]
public partial class Vote : ModelBase
{
    [Attr(PublicName = "userId")]
    [Column("user")]
    public int User { get; set; }

    [Attr] [Column("score")] public int Score { get; set; }

    [Attr] [Column("level")] public string Level { get; set; } = null!;

    [HasOne(PublicName = "user")]
    [ForeignKey("User")]
    [InverseProperty("Votes")]
    public virtual User? UserNavigation { get; set; } = null!;
}
