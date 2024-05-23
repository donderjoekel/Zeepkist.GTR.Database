using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class PersonalBestGlobalProfile
    : AutoMapper.Profile
{
    public PersonalBestGlobalProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestGlobal>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestGlobalUpdateModel>();

    }

}
