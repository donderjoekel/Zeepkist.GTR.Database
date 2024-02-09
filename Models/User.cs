using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("users")]
public partial class User : ModelBase
{
    [Column("steam_id")]
    [StringLength(255)]
    [Attr]
    public string? SteamId { get; set; }

    [Column("steam_name")]
    [StringLength(255)]
    [Attr]
    public string? SteamName { get; set; }

    [Column("discord_id")]
    [StringLength(255)]
    [Attr]
    public string? DiscordId { get; set; }

    [Attr] [Column("banned")] public bool Banned { get; set; } = false;

    [InverseProperty("UserNavigation")] public virtual ICollection<Auth>? Auths { get; set; } = new List<Auth>();

    [InverseProperty("UserNavigation")]
    [HasMany]
    public virtual ICollection<Favorite>? Favorites { get; set; } = new List<Favorite>();

    [InverseProperty("UserNavigation")]
    [HasMany]
    public virtual ICollection<PersonalBest>? PersonalBests { get; set; } = new List<PersonalBest>();

    [HasMany]
    [InverseProperty("UserNavigation")]
    public virtual ICollection<Record>? Records { get; set; } = new List<Record>();

    [HasMany]
    [InverseProperty("UserNavigation")]
    public virtual ICollection<Stat>? Stats { get; set; } = new List<Stat>();

    [HasMany]
    [InverseProperty("UserNavigation")]
    public virtual ICollection<Upvote>? Upvotes { get; set; } = new List<Upvote>();

    [HasMany]
    [InverseProperty("UserNavigation")]
    public virtual ICollection<Vote>? Votes { get; set; } = new List<Vote>();

    [HasMany]
    [InverseProperty("UserNavigation")]
    public virtual ICollection<WorldRecord>? WorldRecordsNavigation { get; set; } = new List<WorldRecord>();

    [HasMany]
    [InverseProperty("UserNavigation")]
    public virtual ICollection<PlayerPoints>? PlayerPoints { get; set; } = new List<PlayerPoints>();
}
