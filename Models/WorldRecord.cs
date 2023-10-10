namespace TNRD.Zeepkist.GTR.Database.Models;

public class WorldRecord : IModel
{
    public int Id { get; set; }

    public int Record { get; set; }

    public int User { get; set; }

    public int Level { get; set; }

    public DateTime? PeriodStart { get; set; }

    public DateTime? PeriodEnd { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public virtual Level LevelNavigation { get; set; } = null!;

    public virtual Record RecordNavigation { get; set; } = null!;

    public virtual User UserNavigation { get; set; } = null!;
}
