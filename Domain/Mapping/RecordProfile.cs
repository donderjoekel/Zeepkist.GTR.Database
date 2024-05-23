using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class RecordProfile
    : AutoMapper.Profile
{
    public RecordProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.Record, Zeepkist.GTR.Database.Domain.Models.RecordReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.RecordCreateModel, Zeepkist.GTR.Database.Data.Entities.Record>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.Record, Zeepkist.GTR.Database.Domain.Models.RecordUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.RecordUpdateModel, Zeepkist.GTR.Database.Data.Entities.Record>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.RecordReadModel, Zeepkist.GTR.Database.Domain.Models.RecordUpdateModel>();

    }

}
