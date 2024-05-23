using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class UserPointsProfile
    : AutoMapper.Profile
{
    public UserPointsProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.UserPoints, Zeepkist.GTR.Database.Domain.Models.UserPointsReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.UserPointsCreateModel, Zeepkist.GTR.Database.Data.Entities.UserPoints>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.UserPoints, Zeepkist.GTR.Database.Domain.Models.UserPointsUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.UserPointsUpdateModel, Zeepkist.GTR.Database.Data.Entities.UserPoints>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.UserPointsReadModel, Zeepkist.GTR.Database.Domain.Models.UserPointsUpdateModel>();

    }

}
