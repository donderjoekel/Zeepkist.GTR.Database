using System;
using FluentValidation;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Validation;

public partial class UserCreateModelValidator
    : AbstractValidator<UserCreateModel>
{
    public UserCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.SteamId).MaximumLength(255);
        RuleFor(p => p.SteamName).MaximumLength(255);
        RuleFor(p => p.DiscordId).MaximumLength(255);
        #endregion
    }

}
