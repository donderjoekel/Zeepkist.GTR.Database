using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class LevelPointsProfile
    : AutoMapper.Profile
{
    public LevelPointsProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelPointsReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelPointsCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelPointsUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelPointsUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.LevelPoints>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelPointsReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelPointsUpdateModel>();

    }

}
