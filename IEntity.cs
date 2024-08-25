namespace TNRD.Zeepkist.GTR.Database;

public interface IEntity
{
    int Id { get; set; }
    DateTimeOffset DateCreated { get; set; }
    DateTimeOffset? DateUpdated { get; set; }
}
