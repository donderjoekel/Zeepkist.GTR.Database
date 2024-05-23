using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class LevelRequestProfile
    : AutoMapper.Profile
{
    public LevelRequestProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.LevelRequest, Zeepkist.GTR.Database.Domain.Models.LevelRequestReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelRequestCreateModel, Zeepkist.GTR.Database.Data.Entities.LevelRequest>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.LevelRequest, Zeepkist.GTR.Database.Domain.Models.LevelRequestUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelRequestUpdateModel, Zeepkist.GTR.Database.Data.Entities.LevelRequest>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelRequestReadModel, Zeepkist.GTR.Database.Domain.Models.LevelRequestUpdateModel>();

    }

}
