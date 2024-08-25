namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class User
    : IEntity, global::JsonApiDotNetCore.Resources.IIdentifiable<int>
{
    public User()
    {
        #region Generated Constructor
        Auths = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Auth>();
        Favorites = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite>();
        PersonalBestDailies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily>();
        PersonalBestGlobals = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>();
        PersonalBestMonthlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly>();
        PersonalBestQuarterlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestQuarterly>();
        PersonalBestWeeklies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly>();
        PersonalBestYearlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly>();
        Records = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Record>();
        StatsDailies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsDaily>();
        StatsGlobals = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsGlobal>();
        StatsMonthlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsMonthly>();
        StatsQuarterlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsQuarterly>();
        StatsWeeklies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsWeekly>();
        StatsYearlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsYearly>();
        Upvotes = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote>();
        UserPoints = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints>();
        #endregion
    }

    #region Generated Properties
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int Id { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string? SteamName { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public bool Banned { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset DateCreated { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset? DateUpdated { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public decimal? SteamId { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public decimal? DiscordId { get; set; }
    #endregion

    #region Generated Relationships
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Auth> Auths { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite> Favorites { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily> PersonalBestDailies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal> PersonalBestGlobals { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly> PersonalBestMonthlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestQuarterly> PersonalBestQuarterlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> PersonalBestWeeklies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly> PersonalBestYearlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Record> Records { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsDaily> StatsDailies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsGlobal> StatsGlobals { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsMonthly> StatsMonthlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsQuarterly> StatsQuarterlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsWeekly> StatsWeeklies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsYearly> StatsYearlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> Upvotes { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints> UserPoints { get; set; }
    #endregion

    #region Generated IIdentifiable Properties
    string global::JsonApiDotNetCore.Resources.IIdentifiable.StringId
    {
        get => Id.ToString();
        set { }
    }
    string global::JsonApiDotNetCore.Resources.IIdentifiable.LocalId
    {
        get => null;
        set { }
    }
    int global::JsonApiDotNetCore.Resources.IIdentifiable<int>.Id
    {
        get => Id;
        set { }
    }
    #endregion

}
