using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class StatsGlobalProfile
    : AutoMapper.Profile
{
    public StatsGlobalProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.StatsGlobal, Zeepkist.GTR.Database.Domain.Models.StatsGlobalReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsGlobalCreateModel, Zeepkist.GTR.Database.Data.Entities.StatsGlobal>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.StatsGlobal, Zeepkist.GTR.Database.Domain.Models.StatsGlobalUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsGlobalUpdateModel, Zeepkist.GTR.Database.Data.Entities.StatsGlobal>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsGlobalReadModel, Zeepkist.GTR.Database.Domain.Models.StatsGlobalUpdateModel>();

    }

}
