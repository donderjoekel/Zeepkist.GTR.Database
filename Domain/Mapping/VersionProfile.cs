using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class VersionProfile
    : AutoMapper.Profile
{
    public VersionProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.Version, Zeepkist.GTR.Database.Domain.Models.VersionReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.VersionCreateModel, Zeepkist.GTR.Database.Data.Entities.Version>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.Version, Zeepkist.GTR.Database.Domain.Models.VersionUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.VersionUpdateModel, Zeepkist.GTR.Database.Data.Entities.Version>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.VersionReadModel, Zeepkist.GTR.Database.Domain.Models.VersionUpdateModel>();

    }

}
