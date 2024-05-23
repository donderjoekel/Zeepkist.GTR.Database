using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class StatsMonthlyProfile
    : AutoMapper.Profile
{
    public StatsMonthlyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsMonthly, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsMonthlyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsMonthlyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.StatsMonthly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsMonthly, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsMonthlyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsMonthlyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.StatsMonthly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsMonthlyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsMonthlyUpdateModel>();

    }

}
