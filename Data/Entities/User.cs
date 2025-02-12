using System;
using System.Collections.Generic;

namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class User
    : IEntity
{
    public User()
    {
        #region Generated Constructor
        Auths = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Auth>();
        Favorites = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite>();
        PersonalBestGlobals = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>();
        Records = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Record>();
        Upvotes = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote>();
        UserPoints = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints>();
        Votes = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Vote>();
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }
    public string? SteamName { get; set; }
    public bool Banned { get; set; }
    public global::System.DateTimeOffset DateCreated { get; set; }
    public global::System.DateTimeOffset? DateUpdated { get; set; }
    public decimal? SteamId { get; set; }
    public decimal? DiscordId { get; set; }
    #endregion

    #region Generated Relationships
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Auth> Auths { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite> Favorites { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal> PersonalBestGlobals { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Record> Records { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> Upvotes { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints> UserPoints { get; set; }
    public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Vote> Votes { get; set; }
    #endregion

}
