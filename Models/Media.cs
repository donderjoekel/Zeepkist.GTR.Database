namespace TNRD.Zeepkist.GTR.Database.Models;

public class Media : IModel
{
    public int Id { get; set; }

    public int Record { get; set; }

    public string GhostUrl { get; set; } = null!;

    public string ScreenshotUrl { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public virtual Record RecordNavigation { get; set; } = null!;
}
