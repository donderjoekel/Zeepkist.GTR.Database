using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class WorldRecordYearlyProfile
    : AutoMapper.Profile
{
    public WorldRecordYearlyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly, Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyCreateModel, Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly, Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyUpdateModel, Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyReadModel, Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyUpdateModel>();

    }

}
