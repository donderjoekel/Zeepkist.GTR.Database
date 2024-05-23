using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class LevelMetadataProfile
    : AutoMapper.Profile
{
    public LevelMetadataProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.LevelMetadata, Zeepkist.GTR.Database.Domain.Models.LevelMetadataReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelMetadataCreateModel, Zeepkist.GTR.Database.Data.Entities.LevelMetadata>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.LevelMetadata, Zeepkist.GTR.Database.Domain.Models.LevelMetadataUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelMetadataUpdateModel, Zeepkist.GTR.Database.Data.Entities.LevelMetadata>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.LevelMetadataReadModel, Zeepkist.GTR.Database.Domain.Models.LevelMetadataUpdateModel>();

    }

}
