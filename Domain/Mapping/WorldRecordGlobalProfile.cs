using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class WorldRecordGlobalProfile
    : AutoMapper.Profile
{
    public WorldRecordGlobalProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal, Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalCreateModel, Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal, Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalUpdateModel, Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalReadModel, Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalUpdateModel>();

    }

}
