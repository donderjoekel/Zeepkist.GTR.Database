using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class WorldRecordYearlyProfile
    : AutoMapper.Profile
{
    public WorldRecordYearlyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.WorldRecordYearly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.WorldRecordYearlyUpdateModel>();

    }

}
