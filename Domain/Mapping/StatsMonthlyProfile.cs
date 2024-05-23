using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class StatsMonthlyProfile
    : AutoMapper.Profile
{
    public StatsMonthlyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.StatsMonthly, Zeepkist.GTR.Database.Domain.Models.StatsMonthlyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsMonthlyCreateModel, Zeepkist.GTR.Database.Data.Entities.StatsMonthly>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.StatsMonthly, Zeepkist.GTR.Database.Domain.Models.StatsMonthlyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsMonthlyUpdateModel, Zeepkist.GTR.Database.Data.Entities.StatsMonthly>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsMonthlyReadModel, Zeepkist.GTR.Database.Domain.Models.StatsMonthlyUpdateModel>();

    }

}
