using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class AuthProfile
    : AutoMapper.Profile
{
    public AuthProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.Auth, Zeepkist.GTR.Database.Domain.Models.AuthReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.AuthCreateModel, Zeepkist.GTR.Database.Data.Entities.Auth>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.Auth, Zeepkist.GTR.Database.Domain.Models.AuthUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.AuthUpdateModel, Zeepkist.GTR.Database.Data.Entities.Auth>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.AuthReadModel, Zeepkist.GTR.Database.Domain.Models.AuthUpdateModel>();

    }

}
