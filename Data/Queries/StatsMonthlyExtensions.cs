using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Queries;

public static partial class StatsMonthlyExtensions
{
    #region Generated Extensions
    public static Zeepkist.GTR.Database.Data.Entities.StatsMonthly? GetByKey(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.StatsMonthly> queryable, int id)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Zeepkist.GTR.Database.Data.Entities.StatsMonthly> dbSet)
            return dbSet.Find(id);

        return queryable.FirstOrDefault(q => q.Id == id);
    }

    public static async System.Threading.Tasks.ValueTask<Zeepkist.GTR.Database.Data.Entities.StatsMonthly?> GetByKeyAsync(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.StatsMonthly> queryable, int id, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Zeepkist.GTR.Database.Data.Entities.StatsMonthly> dbSet)
            return await dbSet.FindAsync(new object[] { id }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.Id == id, cancellationToken);
    }

    public static System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.StatsMonthly> ByLevel(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.StatsMonthly> queryable, int level)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Level == level);
    }

    public static System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.StatsMonthly> ByUser(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.StatsMonthly> queryable, int user)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.User == user);
    }

    #endregion

}
