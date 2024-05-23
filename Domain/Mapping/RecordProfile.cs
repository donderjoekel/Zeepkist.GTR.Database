using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class RecordProfile
    : AutoMapper.Profile
{
    public RecordProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.Record, TNRD.Zeepkist.GTR.Database.Domain.Models.RecordReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.RecordCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.Record>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.Record, TNRD.Zeepkist.GTR.Database.Domain.Models.RecordUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.RecordUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.Record>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.RecordReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.RecordUpdateModel>();

    }

}
