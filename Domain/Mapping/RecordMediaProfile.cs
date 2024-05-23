using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class RecordMediaProfile
    : AutoMapper.Profile
{
    public RecordMediaProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.RecordMedia, Zeepkist.GTR.Database.Domain.Models.RecordMediaReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.RecordMediaCreateModel, Zeepkist.GTR.Database.Data.Entities.RecordMedia>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.RecordMedia, Zeepkist.GTR.Database.Domain.Models.RecordMediaUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.RecordMediaUpdateModel, Zeepkist.GTR.Database.Data.Entities.RecordMedia>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.RecordMediaReadModel, Zeepkist.GTR.Database.Domain.Models.RecordMediaUpdateModel>();

    }

}
