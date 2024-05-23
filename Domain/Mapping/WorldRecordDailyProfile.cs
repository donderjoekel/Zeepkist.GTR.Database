using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class WorldRecordDailyProfile
    : AutoMapper.Profile
{
    public WorldRecordDailyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily, Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyCreateModel, Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily, Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyUpdateModel, Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyReadModel, Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyUpdateModel>();

    }

}
