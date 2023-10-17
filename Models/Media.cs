using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("media")]
public partial class Media : ModelBase
{
    [Column("record")] public int Record { get; set; }

    [Column("ghost_url")] public string GhostUrl { get; set; } = null!;

    [Column("screenshot_url")] public string ScreenshotUrl { get; set; } = null!;

    [ForeignKey("Record")]
    [InverseProperty("Media")]
    public virtual Record? RecordNavigation { get; set; } = null!;
}
