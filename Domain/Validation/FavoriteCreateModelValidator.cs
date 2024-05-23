using System;
using FluentValidation;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Validation;

public partial class FavoriteCreateModelValidator
    : AbstractValidator<FavoriteCreateModel>
{
    public FavoriteCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
