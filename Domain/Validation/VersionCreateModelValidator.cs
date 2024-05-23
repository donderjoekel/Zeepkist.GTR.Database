using System;
using FluentValidation;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Validation;

public partial class VersionCreateModelValidator
    : AbstractValidator<VersionCreateModel>
{
    public VersionCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
