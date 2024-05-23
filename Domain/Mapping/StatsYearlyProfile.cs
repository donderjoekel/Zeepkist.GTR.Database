using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class StatsYearlyProfile
    : AutoMapper.Profile
{
    public StatsYearlyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.StatsYearly, Zeepkist.GTR.Database.Domain.Models.StatsYearlyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsYearlyCreateModel, Zeepkist.GTR.Database.Data.Entities.StatsYearly>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.StatsYearly, Zeepkist.GTR.Database.Domain.Models.StatsYearlyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsYearlyUpdateModel, Zeepkist.GTR.Database.Data.Entities.StatsYearly>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.StatsYearlyReadModel, Zeepkist.GTR.Database.Domain.Models.StatsYearlyUpdateModel>();

    }

}
