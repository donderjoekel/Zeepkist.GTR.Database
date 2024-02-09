using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("upvotes")]
public partial class Upvote : ModelBase
{
    [Column("user")]
    [Attr(PublicName = "userId")]
    public int User { get; set; }

    [Attr] [Column("level")] public string Level { get; set; } = null!;

    [ForeignKey("User")]
    [InverseProperty("Upvotes")]
    [HasOne(PublicName = "user")]
    public virtual User? UserNavigation { get; set; } = null!;
}
