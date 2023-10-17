using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("users")]
public partial class User : ModelBase
{
    [Column("steam_id")]
    [StringLength(255)]
    public string? SteamId { get; set; }

    [Column("steam_name")]
    [StringLength(255)]
    public string? SteamName { get; set; }

    [Column("discord_id")]
    [StringLength(255)]
    public string? DiscordId { get; set; }

    [Column("banned")] public bool Banned { get; set; } = false;

    [InverseProperty("UserNavigation")] public virtual ICollection<Auth>? Auths { get; set; } = new List<Auth>();

    [InverseProperty("UserNavigation")]
    public virtual ICollection<Favorite>? Favorites { get; set; } = new List<Favorite>();

    [InverseProperty("UserNavigation")]
    public virtual ICollection<PersonalBest>? PersonalBests { get; set; } = new List<PersonalBest>();

    [InverseProperty("UserNavigation")] public virtual ICollection<Record>? Records { get; set; } = new List<Record>();
    [InverseProperty("UserNavigation")] public virtual ICollection<Stat>? Stats { get; set; } = new List<Stat>();
    [InverseProperty("UserNavigation")] public virtual ICollection<Upvote>? Upvotes { get; set; } = new List<Upvote>();
    [InverseProperty("UserNavigation")] public virtual ICollection<Vote>? Votes { get; set; } = new List<Vote>();

    [InverseProperty("UserNavigation")]
    public virtual ICollection<WorldRecord>? WorldRecordsNavigation { get; set; } = new List<WorldRecord>();
}
