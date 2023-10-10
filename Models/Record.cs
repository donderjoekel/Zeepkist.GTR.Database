namespace TNRD.Zeepkist.GTR.Database.Models;

public class Record : IModel
{
    public int Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int? Level { get; set; }

    public int? User { get; set; }

    public float? Time { get; set; }

    public bool IsBest { get; set; }

    public string? Splits { get; set; }

    public string? GhostUrl { get; set; }

    public string? ScreenshotUrl { get; set; }

    public string? GameVersion { get; set; }

    public bool IsValid { get; set; }

    public bool IsWr { get; set; }

    public string? LevelHash { get; set; }

    public string? ModVersion { get; set; }

    public virtual Level? LevelNavigation { get; set; }

    public virtual ICollection<Media> Media { get; set; } = new List<Media>();

    public virtual ICollection<PersonalBest> PersonalBests { get; set; } = new List<PersonalBest>();

    public virtual User? UserNavigation { get; set; }

    public virtual ICollection<WorldRecord> WorldRecords { get; set; } = new List<WorldRecord>();
}
