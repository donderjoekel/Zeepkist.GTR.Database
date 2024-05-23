using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class StatsGlobalProfile
    : AutoMapper.Profile
{
    public StatsGlobalProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsGlobal, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsGlobalReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsGlobalCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.StatsGlobal>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsGlobal, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsGlobalUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsGlobalUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.StatsGlobal>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsGlobalReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsGlobalUpdateModel>();

    }

}
