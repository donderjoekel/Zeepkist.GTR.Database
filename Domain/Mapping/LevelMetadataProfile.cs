using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class LevelMetadataProfile
    : AutoMapper.Profile
{
    public LevelMetadataProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelMetadataReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelMetadataCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelMetadataUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelMetadataUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.LevelMetadata>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.LevelMetadataReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.LevelMetadataUpdateModel>();

    }

}
