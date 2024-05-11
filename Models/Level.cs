using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("levels")]
[NoResource]
public partial class Level
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("image_url")]
    public string ImageUrl { get; set; } = null!;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [Column("workshop_id")]
    public decimal WorkshopId { get; set; }

    [Column("author_id")]
    public decimal AuthorId { get; set; }

    [Column("file_hash")]
    public string FileHash { get; set; } = null!;

    [Column("file_url")]
    public string FileUrl { get; set; } = null!;

    [Column("file_author")]
    public string FileAuthor { get; set; } = null!;

    [Column("file_uid")]
    public string FileUid { get; set; } = null!;

    [Column("replaced_by")]
    public int? ReplacedBy { get; set; }

    [Column("deleted")]
    public bool Deleted { get; set; }

    [Column("metadata_id")]
    public int MetadataId { get; set; }

    [ForeignKey("MetadataId")]
    [InverseProperty("Levels")]
    public virtual Metadata Metadata { get; set; } = null!;
}
