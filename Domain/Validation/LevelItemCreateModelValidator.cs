using System;
using FluentValidation;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Validation;

public partial class LevelItemCreateModelValidator
    : AbstractValidator<LevelItemCreateModel>
{
    public LevelItemCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.ImageUrl).NotEmpty();
        RuleFor(p => p.FileHash).NotEmpty();
        RuleFor(p => p.FileUrl).NotEmpty();
        RuleFor(p => p.FileAuthor).NotEmpty();
        RuleFor(p => p.FileUid).NotEmpty();
        #endregion
    }

}
