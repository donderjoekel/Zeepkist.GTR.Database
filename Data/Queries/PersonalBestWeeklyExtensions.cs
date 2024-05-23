using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Zeepkist.GTR.Database.Data.Queries;

public static partial class PersonalBestWeeklyExtensions
{
    #region Generated Extensions
    public static Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly? GetByKey(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> queryable, int id)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> dbSet)
            return dbSet.Find(id);

        return queryable.FirstOrDefault(q => q.Id == id);
    }

    public static async System.Threading.Tasks.ValueTask<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly?> GetByKeyAsync(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> queryable, int id, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> dbSet)
            return await dbSet.FindAsync(new object[] { id }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.Id == id, cancellationToken);
    }

    public static System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> ByLevel(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> queryable, int level)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Level == level);
    }

    public static System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> ByRecord(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> queryable, int record)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.Record == record);
    }

    public static System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> ByUser(this System.Linq.IQueryable<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly> queryable, int user)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        return queryable.Where(q => q.User == user);
    }

    #endregion

}
