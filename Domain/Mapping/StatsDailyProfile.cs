using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class StatsDailyProfile
    : AutoMapper.Profile
{
    public StatsDailyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsDaily, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsDailyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsDailyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.StatsDaily>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsDaily, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsDailyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsDailyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.StatsDaily>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsDailyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsDailyUpdateModel>();

    }

}
