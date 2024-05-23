using System;
using FluentValidation;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Validation;

public partial class UserPointsCreateModelValidator
    : AbstractValidator<UserPointsCreateModel>
{
    public UserPointsCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
