using System;
using FluentValidation;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Validation;

public partial class RecordMediaCreateModelValidator
    : AbstractValidator<RecordMediaCreateModel>
{
    public RecordMediaCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.GhostUrl).NotEmpty();
        RuleFor(p => p.ScreenshotUrl).NotEmpty();
        #endregion
    }

}
