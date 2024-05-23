using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class PersonalBestGlobalProfile
    : AutoMapper.Profile
{
    public PersonalBestGlobalProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal, Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalCreateModel, Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal, Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalUpdateModel, Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalReadModel, Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalUpdateModel>();

    }

}
