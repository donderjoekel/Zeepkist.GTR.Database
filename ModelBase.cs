using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database;

public class ModelBase
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("date_created")]
    public DateTime DateCreated { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [Column("date_updated")]
    public DateTime DateUpdated { get; set; }
}
