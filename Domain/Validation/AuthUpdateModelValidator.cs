using System;
using FluentValidation;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Validation;

public partial class AuthUpdateModelValidator
    : AbstractValidator<AuthUpdateModel>
{
    public AuthUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.AccessToken).MaximumLength(255);
        RuleFor(p => p.AccessTokenExpiry).MaximumLength(255);
        RuleFor(p => p.RefreshToken).MaximumLength(255);
        RuleFor(p => p.RefreshTokenExpiry).MaximumLength(255);
        #endregion
    }

}
