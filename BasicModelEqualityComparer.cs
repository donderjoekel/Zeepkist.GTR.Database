namespace TNRD.Zeepkist.GTR.Database;

public class BasicModelEqualityComparer : IEqualityComparer<IModel>
{
    public static BasicModelEqualityComparer Instance { get; } = new();

    public bool Equals(IModel? x, IModel? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null)) return false;
        if (ReferenceEquals(y, null)) return false;
        if (x.GetType() != y.GetType()) return false;
        return x.Id == y.Id;
    }

    public int GetHashCode(IModel obj)
    {
        return obj.Id;
    }
}
