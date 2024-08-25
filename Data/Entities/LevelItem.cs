namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class LevelItem
    : IEntity, global::JsonApiDotNetCore.Resources.IIdentifiable<int>
{
    public LevelItem()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int Id { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int IdLevel { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public decimal WorkshopId { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public decimal AuthorId { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string Name { get; set; } = null!;
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string ImageUrl { get; set; } = null!;
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string FileAuthor { get; set; } = null!;
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string FileUid { get; set; } = null!;
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public float ValidationTimeAuthor { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public float ValidationTimeGold { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public float ValidationTimeSilver { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public float ValidationTimeBronze { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public bool Deleted { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset CreatedAt { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset UpdatedAt { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset DateCreated { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTimeOffset? DateUpdated { get; set; }
    #endregion

    #region Generated Relationships
    [global::JsonApiDotNetCore.Resources.Annotations.HasOneAttribute] public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.Level Level { get; set; } = null!;
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
