using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class VersionProfile
    : AutoMapper.Profile
{
    public VersionProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.Version, TNRD.Zeepkist.GTR.Database.Domain.Models.VersionReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.VersionCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.Version>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.Version, TNRD.Zeepkist.GTR.Database.Domain.Models.VersionUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.VersionUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.Version>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.VersionReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.VersionUpdateModel>();

    }

}
