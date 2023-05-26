namespace TNRD.Zeepkist.GTR.Database.Models;

public partial class User
{
    public int Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public string? SteamId { get; set; }

    public string? SteamName { get; set; }

    public int? Position { get; set; }

    public float? Score { get; set; }

    public int? WorldRecords { get; set; }

    public string? DiscordId { get; set; }

    public bool? Banned { get; set; }

    public virtual ICollection<Auth> Auths { get; } = new List<Auth>();

    public virtual ICollection<Favorite> Favorites { get; } = new List<Favorite>();

    public virtual ICollection<Level> Levels { get; } = new List<Level>();

    public virtual ICollection<Record> Records { get; } = new List<Record>();

    public virtual ICollection<Upvote> Upvotes { get; } = new List<Upvote>();

    public virtual ICollection<Vote> Votes { get; } = new List<Vote>();
}
