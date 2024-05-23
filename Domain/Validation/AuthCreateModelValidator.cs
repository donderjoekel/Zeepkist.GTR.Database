using System;
using FluentValidation;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Validation;

public partial class AuthCreateModelValidator
    : AbstractValidator<AuthCreateModel>
{
    public AuthCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.AccessToken).MaximumLength(255);
        RuleFor(p => p.AccessTokenExpiry).MaximumLength(255);
        RuleFor(p => p.RefreshToken).MaximumLength(255);
        RuleFor(p => p.RefreshTokenExpiry).MaximumLength(255);
        #endregion
    }

}
