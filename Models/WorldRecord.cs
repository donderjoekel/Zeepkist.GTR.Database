using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("world_records")]
public partial class WorldRecord : ModelBase
{
    [Attr(PublicName = "recordId")]
    [Column("record")]
    public int Record { get; set; }

    [Attr(PublicName = "userId")]
    [Column("user")]
    public int User { get; set; }

    [Attr] [Column("period_start")] public DateTime? PeriodStart { get; set; }

    [Attr] [Column("period_end")] public DateTime? PeriodEnd { get; set; }

    [Attr] [Column("level")] public string Level { get; set; } = null!;

    [HasOne(PublicName = "record")]
    [ForeignKey("Record")]
    [InverseProperty("WorldRecords")]
    public virtual Record? RecordNavigation { get; set; } = null!;

    [HasOne(PublicName = "user")]
    [ForeignKey("User")]
    [InverseProperty("WorldRecordsNavigation")]
    public virtual User? UserNavigation { get; set; } = null!;
}
