using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class UserProfile
    : AutoMapper.Profile
{
    public UserProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.User, TNRD.Zeepkist.GTR.Database.Domain.Models.UserReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.UserCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.User>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.User, TNRD.Zeepkist.GTR.Database.Domain.Models.UserUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.UserUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.User>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.UserReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.UserUpdateModel>();

    }

}
