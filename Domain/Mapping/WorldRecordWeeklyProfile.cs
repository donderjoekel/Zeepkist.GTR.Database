using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class WorldRecordWeeklyProfile
    : AutoMapper.Profile
{
    public WorldRecordWeeklyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyUpdateModel>();

    }

}
