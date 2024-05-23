using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Queries;

public static partial class LevelItemExtensions
{
    #region Generated Extensions
    public static Zeepkist.GTR.Database.Data.Entities.LevelItem? GetByKey(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.LevelItem> queryable, int id)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Zeepkist.GTR.Database.Data.Entities.LevelItem> dbSet)
            return dbSet.Find(id);

        return queryable.FirstOrDefault(q => q.Id == id);
    }

    public static async System.Threading.Tasks.ValueTask<Zeepkist.GTR.Database.Data.Entities.LevelItem?> GetByKeyAsync(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.LevelItem> queryable, int id, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Zeepkist.GTR.Database.Data.Entities.LevelItem> dbSet)
            return await dbSet.FindAsync(new object[] { id }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.Id == id, cancellationToken);
    }

    public static System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.LevelItem> ByMetadataId(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.LevelItem> queryable, int metadataId)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.MetadataId == metadataId);
    }

    #endregion

}
