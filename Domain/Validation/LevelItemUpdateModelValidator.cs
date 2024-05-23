using System;
using FluentValidation;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Validation;

public partial class LevelItemUpdateModelValidator
    : AbstractValidator<LevelItemUpdateModel>
{
    public LevelItemUpdateModelValidator()
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
