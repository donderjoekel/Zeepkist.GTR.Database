using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class Auth
    : IEntity
{
    public Auth()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }
    public int? IdUser { get; set; }
    public string? AccessToken { get; set; }
    public long? AccessTokenExpiry { get; set; }
    public string? RefreshToken { get; set; }
    public long? RefreshTokenExpiry { get; set; }
    public int? Type { get; set; }
    public global::System.DateTimeOffset DateCreated { get; set; }
    public global::System.DateTimeOffset? DateUpdated { get; set; }
    #endregion

    #region Generated Relationships
    public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.User? User { get; set; }
    #endregion

}
