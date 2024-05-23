using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class StatsDailyProfile
    : AutoMapper.Profile
{
    public StatsDailyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.StatsDaily, Zeepkist.GTR.Database.Domain.Models.StatsDailyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsDailyCreateModel, Zeepkist.GTR.Database.Data.Entities.StatsDaily>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.StatsDaily, Zeepkist.GTR.Database.Domain.Models.StatsDailyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsDailyUpdateModel, Zeepkist.GTR.Database.Data.Entities.StatsDaily>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsDailyReadModel, Zeepkist.GTR.Database.Domain.Models.StatsDailyUpdateModel>();

    }

}
