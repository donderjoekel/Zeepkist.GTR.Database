using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class LevelPointsProfile
    : AutoMapper.Profile
{
    public LevelPointsProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.LevelPoints, Zeepkist.GTR.Database.Domain.Models.LevelPointsReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelPointsCreateModel, Zeepkist.GTR.Database.Data.Entities.LevelPoints>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.LevelPoints, Zeepkist.GTR.Database.Domain.Models.LevelPointsUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelPointsUpdateModel, Zeepkist.GTR.Database.Data.Entities.LevelPoints>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelPointsReadModel, Zeepkist.GTR.Database.Domain.Models.LevelPointsUpdateModel>();

    }

}
