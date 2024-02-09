using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("media")]
public partial class Media : ModelBase
{
    [Column("record")]
    [Attr(PublicName = "recordId")]
    public int Record { get; set; }

    [Column("ghost_url")] [Attr] public string GhostUrl { get; set; } = null!;

    [Column("screenshot_url")] [Attr] public string ScreenshotUrl { get; set; } = null!;

    [ForeignKey("Record")]
    [InverseProperty("Media")]
    [HasOne(PublicName = "record")]
    public virtual Record? RecordNavigation { get; set; } = null!;
}
