using System;
using FluentValidation;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Validation;

public partial class VersionUpdateModelValidator
    : AbstractValidator<VersionUpdateModel>
{
    public VersionUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
