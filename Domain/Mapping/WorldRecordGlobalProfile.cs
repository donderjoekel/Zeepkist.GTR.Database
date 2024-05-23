using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class WorldRecordGlobalProfile
    : AutoMapper.Profile
{
    public WorldRecordGlobalProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordGlobal>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordGlobalUpdateModel>();

    }

}
