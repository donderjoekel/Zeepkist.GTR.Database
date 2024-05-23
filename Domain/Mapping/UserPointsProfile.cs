using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class UserPointsProfile
    : AutoMapper.Profile
{
    public UserPointsProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints, TNRD.Zeepkist.GTR.Database.Domain.Models.UserPointsReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.UserPointsCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints, TNRD.Zeepkist.GTR.Database.Domain.Models.UserPointsUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.UserPointsUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.UserPoints>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.UserPointsReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.UserPointsUpdateModel>();

    }

}
