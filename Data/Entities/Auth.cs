namespace TNRD.Zeepkist.GTR.Database.Data.Entities;

public partial class Auth
    : IEntity, global::JsonApiDotNetCore.Resources.IIdentifiable<int>
{
    public Auth()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int Id { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int? IdUser { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string? AccessToken { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public long? AccessTokenExpiry { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public string? RefreshToken { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public long? RefreshTokenExpiry { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public int? Type { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTime DateCreated { get; set; }
    [global::JsonApiDotNetCore.Resources.Annotations.AttrAttribute] public global::System.DateTime? DateUpdated { get; set; }
    #endregion

    #region Generated Relationships
    [global::JsonApiDotNetCore.Resources.Annotations.HasOneAttribute] public virtual global::TNRD.Zeepkist.GTR.Database.Data.Entities.User? User { get; set; }
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
