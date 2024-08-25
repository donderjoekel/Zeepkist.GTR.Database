namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class UserPoints
    : IEntity, global::JsonApiDotNetCore.Resources.IIdentifiable<int>
{
    public UserPoints()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int Id { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int IdUser { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int Points { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset DateCreated { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset? DateUpdated { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int Rank { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int? WorldRecords { get; set; }
    #endregion

    #region Generated Relationships
    [global::JsonApiDotNetCore.Resources.Annotations.HasOneAttribute] public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.User User { get; set; } = null!;
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
