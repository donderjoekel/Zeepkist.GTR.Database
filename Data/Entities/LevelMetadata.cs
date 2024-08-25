namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class LevelMetadata
    : IEntity, global::JsonApiDotNetCore.Resources.IIdentifiable<int>
{
    public LevelMetadata()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int Id { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int IdLevel { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int AmountCheckpoints { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int AmountFinishes { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int AmountBlocks { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int TypeGround { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int TypeSkybox { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string Blocks { get; set; } = null!;
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
