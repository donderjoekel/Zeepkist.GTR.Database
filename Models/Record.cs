using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("records")]
public partial class Record : ModelBase
{
    [Column("user")] public int User { get; set; }

    [Column("time")] public float Time { get; set; }

    [Column("splits")] public string? Splits { get; set; }

    [Column("game_version")]
    [StringLength(255)]
    public string GameVersion { get; set; } = null!;

    [Column("is_valid")] public bool IsValid { get; set; }

    [Column("level")] public string Level { get; set; } = null!;

    [Column("mod_version")] public string ModVersion { get; set; } = null!;

    [InverseProperty("RecordNavigation")] public virtual ICollection<Media> Media { get; set; } = new List<Media>();

    [InverseProperty("RecordNavigation")]
    public virtual ICollection<PersonalBest> PersonalBests { get; set; } = new List<PersonalBest>();

    [ForeignKey("User")]
    [InverseProperty("Records")]
    public virtual User? UserNavigation { get; set; }

    [InverseProperty("RecordNavigation")]
    public virtual ICollection<WorldRecord> WorldRecords { get; set; } = new List<WorldRecord>();
}
