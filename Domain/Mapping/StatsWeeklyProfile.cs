using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class StatsWeeklyProfile
    : AutoMapper.Profile
{
    public StatsWeeklyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.StatsWeekly, Zeepkist.GTR.Database.Domain.Models.StatsWeeklyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsWeeklyCreateModel, Zeepkist.GTR.Database.Data.Entities.StatsWeekly>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.StatsWeekly, Zeepkist.GTR.Database.Domain.Models.StatsWeeklyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsWeeklyUpdateModel, Zeepkist.GTR.Database.Data.Entities.StatsWeekly>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsWeeklyReadModel, Zeepkist.GTR.Database.Domain.Models.StatsWeeklyUpdateModel>();

    }

}
