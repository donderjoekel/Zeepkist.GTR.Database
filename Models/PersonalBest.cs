using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("personal_bests")]
public partial class PersonalBest : ModelBase
{
    [Column("record")]
    [Attr(PublicName = "recordId")]
    public int Record { get; set; }

    [Column("user")]
    [Attr(PublicName = "userId")]
    public int User { get; set; }

    [Column("period_start")] [Attr] public DateTime? PeriodStart { get; set; }

    [Column("period_end")] [Attr] public DateTime? PeriodEnd { get; set; }

    [Column("level")] [Attr] public string Level { get; set; } = null!;

    [ForeignKey("Record")]
    [InverseProperty("PersonalBests")]
    [HasOne(PublicName = "record")]
    public virtual Record? RecordNavigation { get; set; } = null!;

    [ForeignKey("User")]
    [InverseProperty("PersonalBests")]
    [HasOne(PublicName = "user")]
    public virtual User? UserNavigation { get; set; } = null!;
}
