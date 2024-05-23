using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Data.Entities;

public partial class Auth
{
    public Auth()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public int? User { get; set; }

    public string? AccessToken { get; set; }

    public string? AccessTokenExpiry { get; set; }

    public string? RefreshToken { get; set; }

    public string? RefreshTokenExpiry { get; set; }

    public int? Type { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    #endregion

    #region Generated Relationships
    public virtual User? User1 { get; set; }

    #endregion

}
