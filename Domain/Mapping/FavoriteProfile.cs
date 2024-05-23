using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class FavoriteProfile
    : AutoMapper.Profile
{
    public FavoriteProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite, TNRD.Zeepkist.GTR.Database.Domain.Models.FavoriteReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.FavoriteCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite, TNRD.Zeepkist.GTR.Database.Domain.Models.FavoriteUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.FavoriteUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.Favorite>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.FavoriteReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.FavoriteUpdateModel>();

    }

}
