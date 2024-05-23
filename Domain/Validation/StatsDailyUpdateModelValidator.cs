using System;
using FluentValidation;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Validation;

public partial class StatsDailyUpdateModelValidator
    : AbstractValidator<StatsDailyUpdateModel>
{
    public StatsDailyUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Data).NotEmpty();
        #endregion
    }

}
