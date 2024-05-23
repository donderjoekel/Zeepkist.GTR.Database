using System;
using FluentValidation;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Validation;

public partial class StatsYearlyUpdateModelValidator
    : AbstractValidator<StatsYearlyUpdateModel>
{
    public StatsYearlyUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Data).NotEmpty();
        #endregion
    }

}
