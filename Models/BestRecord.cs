namespace TNRD.Zeepkist.GTR.Database.Models;

public class BestRecord : IModel
{
    public int Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int? Level { get; set; }

    public string? LevelHash { get; set; }

    public int? User { get; set; }

    public float? Time { get; set; }

    public string? Splits { get; set; }

    public string? GhostUrl { get; set; }

    public string? ScreenshotUrl { get; set; }

    public string? GameVersion { get; set; }

    public bool IsValid { get; set; }
}
