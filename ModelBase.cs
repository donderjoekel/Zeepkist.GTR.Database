using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace TNRD.Zeepkist.GTR.Database;

public class ModelBase : IIdentifiable<int>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    [Attr]
    public int Id { get; set; }

    [Column("date_created")] [Attr] public DateTime DateCreated { get; set; }

    [Column("date_updated")] [Attr] public DateTime DateUpdated { get; set; }

    string? IIdentifiable.StringId
    {
        get => Id.ToString();
        set { }
    }

    string? IIdentifiable.LocalId
    {
        get => Id.ToString();
        set { }
    }
}
