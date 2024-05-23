using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class LevelItemProfile
    : AutoMapper.Profile
{
    public LevelItemProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.LevelItem, Zeepkist.GTR.Database.Domain.Models.LevelItemReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelItemCreateModel, Zeepkist.GTR.Database.Data.Entities.LevelItem>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.LevelItem, Zeepkist.GTR.Database.Domain.Models.LevelItemUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelItemUpdateModel, Zeepkist.GTR.Database.Data.Entities.LevelItem>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelItemReadModel, Zeepkist.GTR.Database.Domain.Models.LevelItemUpdateModel>();

    }

}
