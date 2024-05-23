using System;
using FluentValidation;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Validation;

public partial class UserPointsUpdateModelValidator
    : AbstractValidator<UserPointsUpdateModel>
{
    public UserPointsUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
