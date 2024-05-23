using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Queries;

public static partial class AuthExtensions
{
    #region Generated Extensions
    public static Zeepkist.GTR.Database.Data.Entities.Auth? GetByKey(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.Auth> queryable, int id)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Zeepkist.GTR.Database.Data.Entities.Auth> dbSet)
            return dbSet.Find(id);

        return queryable.FirstOrDefault(q => q.Id == id);
    }

    public static async System.Threading.Tasks.ValueTask<Zeepkist.GTR.Database.Data.Entities.Auth?> GetByKeyAsync(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.Auth> queryable, int id, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Zeepkist.GTR.Database.Data.Entities.Auth> dbSet)
            return await dbSet.FindAsync(new object[] { id }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.Id == id, cancellationToken);
    }

    public static System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.Auth> ByUser(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.Auth> queryable, int? user)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => (q.User == user || (user == null && q.User == null)));
    }

    #endregion

}
