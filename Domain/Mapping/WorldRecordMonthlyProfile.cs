using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class WorldRecordMonthlyProfile
    : AutoMapper.Profile
{
    public WorldRecordMonthlyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordMonthly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordMonthlyUpdateModel>();

    }

}
