using System;
using FluentValidation;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Validation;

public partial class UserPointsCreateModelValidator
    : AbstractValidator<UserPointsCreateModel>
{
    public UserPointsCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
