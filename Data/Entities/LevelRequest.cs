namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class LevelRequest
    : IEntity, global::JsonApiDotNetCore.Resources.IIdentifiable<int>
{
    public LevelRequest()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int Id { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public decimal WorkshopId { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string? Uid { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string? Hash { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset DateCreated { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset? DateUpdated { get; set; }
    #endregion

    #region Generated Relationships
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
