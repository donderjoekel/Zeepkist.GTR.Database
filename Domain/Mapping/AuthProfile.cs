using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class AuthProfile
    : AutoMapper.Profile
{
    public AuthProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.Auth, TNRD.Zeepkist.GTR.Database.Domain.Models.AuthReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.AuthCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.Auth>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.Auth, TNRD.Zeepkist.GTR.Database.Domain.Models.AuthUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.AuthUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.Auth>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.AuthReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.AuthUpdateModel>();

    }

}
