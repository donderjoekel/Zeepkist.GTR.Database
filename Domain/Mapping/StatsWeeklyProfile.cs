using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class StatsWeeklyProfile
    : AutoMapper.Profile
{
    public StatsWeeklyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsWeekly, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsWeeklyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsWeeklyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.StatsWeekly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsWeekly, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsWeeklyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsWeeklyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.StatsWeekly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsWeeklyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsWeeklyUpdateModel>();

    }

}
