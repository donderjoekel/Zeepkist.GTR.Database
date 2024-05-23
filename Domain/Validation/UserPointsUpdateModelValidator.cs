using System;
using FluentValidation;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Validation;

public partial class UserPointsUpdateModelValidator
    : AbstractValidator<UserPointsUpdateModel>
{
    public UserPointsUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
