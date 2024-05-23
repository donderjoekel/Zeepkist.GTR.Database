using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class RecordMediaProfile
    : AutoMapper.Profile
{
    public RecordMediaProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia, TNRD.Zeepkist.GTR.Database.Domain.Models.RecordMediaReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.RecordMediaCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia, TNRD.Zeepkist.GTR.Database.Domain.Models.RecordMediaUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.RecordMediaUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.RecordMedia>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.RecordMediaReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.RecordMediaUpdateModel>();

    }

}
