using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TNRD.Zeepkist.GTR.Database.Data.Queries;

public static partial class UpvoteExtensions
{
    #region Generated Extensions
    public static TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote? GetByKey(this System.Linq.IQueryable<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> queryable, int id)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> dbSet)
            return dbSet.Find(id);

        return queryable.FirstOrDefault(q => q.Id == id);
    }

    public static async System.Threading.Tasks.ValueTask<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote?> GetByKeyAsync(this System.Linq.IQueryable<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> queryable, int id, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> dbSet)
            return await dbSet.FindAsync(new object[] { id }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.Id == id, cancellationToken);
    }

    public static System.Linq.IQueryable<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> ByLevel(this System.Linq.IQueryable<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> queryable, int level)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Level == level);
    }

    public static System.Linq.IQueryable<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> ByUser(this System.Linq.IQueryable<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote> queryable, int user)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.User == user);
    }

    #endregion

}
