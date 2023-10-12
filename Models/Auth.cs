using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNRD.Zeepkist.GTR.Database.Models;

/// <summary>
/// @omit
/// </summary>
[Table("auth")]
public partial class Auth : ModelBase
{
    [Column("user")] public int? User { get; set; }

    [Column("access_token")]
    [StringLength(255)]
    public string? AccessToken { get; set; }

    [Column("access_token_expiry")]
    [StringLength(255)]
    public string? AccessTokenExpiry { get; set; }

    [Column("refresh_token")]
    [StringLength(255)]
    public string? RefreshToken { get; set; }

    [Column("refresh_token_expiry")]
    [StringLength(255)]
    public string? RefreshTokenExpiry { get; set; }

    [Column("type")] public int? Type { get; set; }

    [ForeignKey("User")]
    [InverseProperty("Auths")]
    public virtual User? UserNavigation { get; set; }
}
