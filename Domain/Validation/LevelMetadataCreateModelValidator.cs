using System;
using FluentValidation;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Validation;

public partial class LevelMetadataCreateModelValidator
    : AbstractValidator<LevelMetadataCreateModel>
{
    public LevelMetadataCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Hash).NotEmpty();
        RuleFor(p => p.Blocks).NotEmpty();
        #endregion
    }

}
