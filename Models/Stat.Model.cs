namespace TNRD.Zeepkist.GTR.Database.Models;

public partial class Stat : IModel
{
    public int Id { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
}
