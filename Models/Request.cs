using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Resources.Annotations;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Models;

[Table("requests")]
[NoResource]
public partial class Request
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("workshop_id")]
    public decimal WorkshopId { get; set; }

    [Column("uid")]
    public string? Uid { get; set; }

    [Column("hash")]
    public string? Hash { get; set; }

    [Column("date_created")]
    public DateTime DateCreated { get; set; }
}
