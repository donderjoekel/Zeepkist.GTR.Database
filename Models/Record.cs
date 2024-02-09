using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("records")]
public partial class Record : ModelBase
{
    [Column("user")]
    [Attr(PublicName = "userId")]
    public int User { get; set; }

    [Column("time")] [Attr] public float Time { get; set; }

    [Column("splits")] [Attr] public string? Splits { get; set; }

    [Column("game_version")]
    [StringLength(255)]
    [Attr]
    public string GameVersion { get; set; } = null!;

    [Column("is_valid")] [Attr] public bool IsValid { get; set; }

    [Column("level")] [Attr] public string Level { get; set; } = null!;

    [Column("mod_version")] [Attr] public string ModVersion { get; set; } = null!;

    [InverseProperty("RecordNavigation")]
    [HasMany]
    public virtual ICollection<Media>? Media { get; set; } = new List<Media>();

    [InverseProperty("RecordNavigation")]
    [HasMany]
    public virtual ICollection<PersonalBest>? PersonalBests { get; set; } = new List<PersonalBest>();

    [ForeignKey("User")]
    [InverseProperty("Records")]
    [HasOne(PublicName = "user")]
    public virtual User? UserNavigation { get; set; }

    [InverseProperty("RecordNavigation")]
    [HasMany]
    public virtual ICollection<WorldRecord>? WorldRecords { get; set; } = new List<WorldRecord>();
}
