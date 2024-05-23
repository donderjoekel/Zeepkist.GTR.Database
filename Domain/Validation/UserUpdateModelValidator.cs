using System;
using FluentValidation;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Validation;

public partial class UserUpdateModelValidator
    : AbstractValidator<UserUpdateModel>
{
    public UserUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.SteamId).MaximumLength(255);
        RuleFor(p => p.SteamName).MaximumLength(255);
        RuleFor(p => p.DiscordId).MaximumLength(255);
        #endregion
    }

}
