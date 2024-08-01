namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class Record
    : IEntity, global::JsonApiDotNetCore.Resources.IIdentifiable<int>
{
    public Record()
    {
        #region Generated Constructor
        PersonalBestDailies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily>();
        PersonalBestGlobals = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>();
        PersonalBestMonthlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly>();
        PersonalBestQuarterlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestQuarterly>();
        PersonalBestWeeklies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly>();
        PersonalBestYearlies = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly>();
        RecordMedia = new global::System.Collections.Generic.HashSet<TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia>();
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
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int IdUser { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public float Time { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string GameVersion { get; set; } = null!;
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public bool IsValid { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int IdLevel { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string ModVersion { get; set; } = null!;
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTime DateCreated { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTime? DateUpdated { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.Collections.Generic.List<float>? Splits { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.Collections.Generic.List<float>? Speeds { get; set; }
    #endregion

    #region Generated Relationships
    [global::JsonApiDotNetCore.Resources.Annotations.HasOneAttribute] public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.Level Level { get; set; } = null!;
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily> PersonalBestDailies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal> PersonalBestGlobals { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly> PersonalBestMonthlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestQuarterly> PersonalBestQuarterlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> PersonalBestWeeklies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly> PersonalBestYearlies { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasManyAttribute] public virtual global::System.Collections.Generic.ICollection<TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia> RecordMedia { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.HasOneAttribute] public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.User User { get; set; } = null!;
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
