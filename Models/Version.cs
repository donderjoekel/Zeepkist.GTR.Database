namespace TNRD.Zeepkist.GTR.Database.Models;

public partial class Version
{
    public int Id { get; set; }

    public string? Minimum { get; set; }

    public string? Latest { get; set; }
}
