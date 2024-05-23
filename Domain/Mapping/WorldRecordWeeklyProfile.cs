using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class WorldRecordWeeklyProfile
    : AutoMapper.Profile
{
    public WorldRecordWeeklyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly, Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyCreateModel, Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly, Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyUpdateModel, Zeepkist.GTR.Database.Data.Entities.WorldRecordWeekly>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyReadModel, Zeepkist.GTR.Database.Domain.Models.WorldRecordWeeklyUpdateModel>();

    }

}
