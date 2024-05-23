using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class LevelRequestProfile
    : AutoMapper.Profile
{
    public LevelRequestProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelRequest, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelRequestReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelRequestCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.LevelRequest>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelRequest, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelRequestUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelRequestUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.LevelRequest>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelRequestReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelRequestUpdateModel>();

    }

}
