using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class UpvoteProfile
    : AutoMapper.Profile
{
    public UpvoteProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote, TNRD.Zeepkist.GTR.Database.Domain.Models.UpvoteReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.UpvoteCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote, TNRD.Zeepkist.GTR.Database.Domain.Models.UpvoteUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.UpvoteUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.Upvote>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.UpvoteReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.UpvoteUpdateModel>();

    }

}
