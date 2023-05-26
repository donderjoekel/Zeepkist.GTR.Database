namespace TNRD.Zeepkist.GTR.Database;

public interface IModel
{
    int Id { get; set; }
    DateTime? DateCreated { get; set; }
    DateTime? DateUpdated { get; set; }
}
