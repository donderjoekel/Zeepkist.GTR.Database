using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class FavoriteProfile
    : AutoMapper.Profile
{
    public FavoriteProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.Favorite, Zeepkist.GTR.Database.Domain.Models.FavoriteReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.FavoriteCreateModel, Zeepkist.GTR.Database.Data.Entities.Favorite>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.Favorite, Zeepkist.GTR.Database.Domain.Models.FavoriteUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.FavoriteUpdateModel, Zeepkist.GTR.Database.Data.Entities.Favorite>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.FavoriteReadModel, Zeepkist.GTR.Database.Domain.Models.FavoriteUpdateModel>();

    }

}
