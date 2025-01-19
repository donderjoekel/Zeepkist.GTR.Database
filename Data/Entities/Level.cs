namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class Level
    : IEntity, global::JsonApiDotNetCore.Resources.IIdentifiable<int>
{
    public Level()
    {
        #region Generated Constructor
        Favorites = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite>();
        LevelItems = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem>();
        LevelMetadata = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata>();
        LevelPoints = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints>();
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
        Votes = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Vote>();
        WorldRecordDailies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily>();
        WorldRecordGlobals = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal>();
        WorldRecordMonthlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly>();
        WorldRecordQuarterlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordQuarterly>();
        WorldRecordWeeklies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly>();
        WorldRecordYearlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly>();
        #endregion
    }

    #region Generated Properties
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int Id { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string Hash { get; set; } = null!;
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset DateCreated { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset? DateUpdated { get; set; }
    #endregion

    #region Generated Relationships
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite> Favorites { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem> LevelItems { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata> LevelMetadata { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints> LevelPoints { get; set; }
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
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.Vote> Votes { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily> WorldRecordDailies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal> WorldRecordGlobals { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly> WorldRecordMonthlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordQuarterly> WorldRecordQuarterlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly> WorldRecordWeeklies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly> WorldRecordYearlies { get; set; }
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
