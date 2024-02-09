using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("favorites")]
public partial class Favorite : ModelBase
{
    [Column("user")]
    [Attr(PublicName = "userId")]
    public int User { get; set; }

    [Column("level")] [Attr] public string Level { get; set; } = null!;

    [ForeignKey("User")]
    [InverseProperty("Favorites")]
    [HasOne(PublicName = "user")]
    public virtual User? UserNavigation { get; set; } = null!;
}
