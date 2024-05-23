using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Queries;

public static partial class LevelMetadataExtensions
{
    #region Generated Extensions
    public static TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata? GetByKey(this System.Linq.IQueryable<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata> queryable, int id)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata> dbSet)
            return dbSet.Find(id);

        return queryable.FirstOrDefault(q => q.Id == id);
    }

    public static async System.Threading.Tasks.ValueTask<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata?> GetByKeyAsync(this System.Linq.IQueryable<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata> queryable, int id, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata> dbSet)
            return await dbSet.FindAsync(new object[] { id }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.Id == id, cancellationToken);
    }

    #endregion

}
