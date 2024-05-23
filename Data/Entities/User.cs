using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Data.Entities;

public partial class User
{
    public User()
    {
        #region Generated Constructor
        Auths = new HashSet<Auth>();
        Favorites = new HashSet<Favorite>();
        PersonalBestDailies = new HashSet<PersonalBestDaily>();
        PersonalBestGlobals = new HashSet<PersonalBestGlobal>();
        PersonalBestMonthlies = new HashSet<PersonalBestMonthly>();
        PersonalBestWeeklies = new HashSet<PersonalBestWeekly>();
        PersonalBestYearlies = new HashSet<PersonalBestYearly>();
        Records = new HashSet<Record>();
        StatsDailies = new HashSet<StatsDaily>();
        StatsGlobals = new HashSet<StatsGlobal>();
        StatsMonthlies = new HashSet<StatsMonthly>();
        StatsWeeklies = new HashSet<StatsWeekly>();
        StatsYearlies = new HashSet<StatsYearly>();
        Upvotes = new HashSet<Upvote>();
        UserPoints = new HashSet<UserPoints>();
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public string? SteamId { get; set; }

    public string? SteamName { get; set; }

    public string? DiscordId { get; set; }

    public bool Banned { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<Auth> Auths { get; set; }

    public virtual ICollection<Favorite> Favorites { get; set; }

    public virtual ICollection<PersonalBestDaily> PersonalBestDailies { get; set; }

    public virtual ICollection<PersonalBestGlobal> PersonalBestGlobals { get; set; }

    public virtual ICollection<PersonalBestMonthly> PersonalBestMonthlies { get; set; }

    public virtual ICollection<PersonalBestWeekly> PersonalBestWeeklies { get; set; }

    public virtual ICollection<PersonalBestYearly> PersonalBestYearlies { get; set; }

    public virtual ICollection<Record> Records { get; set; }

    public virtual ICollection<StatsDaily> StatsDailies { get; set; }

    public virtual ICollection<StatsGlobal> StatsGlobals { get; set; }

    public virtual ICollection<StatsMonthly> StatsMonthlies { get; set; }

    public virtual ICollection<StatsWeekly> StatsWeeklies { get; set; }

    public virtual ICollection<StatsYearly> StatsYearlies { get; set; }

    public virtual ICollection<Upvote> Upvotes { get; set; }

    public virtual ICollection<UserPoints> UserPoints { get; set; }

    #endregion

}
