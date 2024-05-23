using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class StatsYearlyProfile
    : AutoMapper.Profile
{
    public StatsYearlyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsYearly, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsYearlyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsYearlyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.StatsYearly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.StatsYearly, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsYearlyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsYearlyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.StatsYearly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.StatsYearlyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.StatsYearlyUpdateModel>();

    }

}
