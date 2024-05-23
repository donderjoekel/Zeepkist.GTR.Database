using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class WorldRecordDailyProfile
    : AutoMapper.Profile
{
    public WorldRecordDailyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordDaily>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordDailyUpdateModel>();

    }

}
