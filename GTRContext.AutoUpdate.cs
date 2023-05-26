using Microsoft.EntityFrameworkCore;
using TNRD.Zeepkist.GTR.Database.Models;

namespace TNRD.Zeepkist.GTR.Database;

public partial class GTRContext
{
    private void UpdateDateUpdated()
    {
        IEnumerable<object> entries = ChangeTracker.Entries()
            .Where(x => x.State == EntityState.Modified)
            .Select(x => x.Entity);

        DateTime stamp = DateTime.UtcNow;

        foreach (object entry in entries)
        {
            if (entry is IModel model)
            {
                model.DateUpdated = stamp;
            }
        }
    }

    /// <inheritdoc />
    public override int SaveChanges()
    {
        UpdateDateUpdated();
        return base.SaveChanges();
    }

    /// <inheritdoc />
    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        UpdateDateUpdated();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    /// <inheritdoc />
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        UpdateDateUpdated();
        return base.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc />
    public override Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = new()
    )
    {
        UpdateDateUpdated();
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }
}
