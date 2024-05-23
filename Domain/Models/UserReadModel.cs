using System;
using System.Collections.Generic;

namespace Zeepkist.GTR.Database.Domain.Models;

public partial class UserReadModel
{
    #region Generated Properties
    public int Id { get; set; }

    public string? SteamId { get; set; }

    public string? SteamName { get; set; }

    public string? DiscordId { get; set; }

    public bool Banned { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    #endregion

}
