using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class UserProfile
    : AutoMapper.Profile
{
    public UserProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.User, Zeepkist.GTR.Database.Domain.Models.UserReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.UserCreateModel, Zeepkist.GTR.Database.Data.Entities.User>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.User, Zeepkist.GTR.Database.Domain.Models.UserUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.UserUpdateModel, Zeepkist.GTR.Database.Data.Entities.User>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.UserReadModel, Zeepkist.GTR.Database.Domain.Models.UserUpdateModel>();

    }

}
