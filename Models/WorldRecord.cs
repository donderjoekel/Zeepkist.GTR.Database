using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("world_records")]
public partial class WorldRecord : ModelBase
{
    [Column("record")] public int Record { get; set; }

    [Column("user")] public int User { get; set; }

    [Column("period_start")] public DateTime? PeriodStart { get; set; }

    [Column("period_end")] public DateTime? PeriodEnd { get; set; }

    [Column("level")] public string Level { get; set; } = null!;

    [ForeignKey("Record")]
    [InverseProperty("WorldRecords")]
    public virtual Record RecordNavigation { get; set; } = null!;

    [ForeignKey("User")]
    [InverseProperty("WorldRecordsNavigation")]
    public virtual User UserNavigation { get; set; } = null!;
}
