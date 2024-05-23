using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class WorldRecordMonthlyProfile
    : AutoMapper.Profile
{
    public WorldRecordMonthlyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly, Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyCreateModel, Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly, Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyUpdateModel, Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyReadModel, Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyUpdateModel>();

    }

}
