using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class LevelItemProfile
    : AutoMapper.Profile
{
    public LevelItemProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelItemReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelItemCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelItemUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelItemUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.LevelItem>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelItemReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelItemUpdateModel>();

    }

}
