using System;
using FluentValidation;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Validation;

public partial class StatsDailyCreateModelValidator
    : AbstractValidator<StatsDailyCreateModel>
{
    public StatsDailyCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Data).NotEmpty();
        #endregion
    }

}
