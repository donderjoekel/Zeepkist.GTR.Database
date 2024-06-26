using System;
using FluentValidation;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Validation;

public partial class RecordUpdateModelValidator
    : AbstractValidator<RecordUpdateModel>
{
    public RecordUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.GameVersion).NotEmpty();
        RuleFor(p => p.GameVersion).MaximumLength(255);
        RuleFor(p => p.ModVersion).NotEmpty();
        #endregion
    }

}
