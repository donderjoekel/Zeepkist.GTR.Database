using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class UpvoteProfile
    : AutoMapper.Profile
{
    public UpvoteProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.Upvote, Zeepkist.GTR.Database.Domain.Models.UpvoteReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.UpvoteCreateModel, Zeepkist.GTR.Database.Data.Entities.Upvote>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.Upvote, Zeepkist.GTR.Database.Domain.Models.UpvoteUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.UpvoteUpdateModel, Zeepkist.GTR.Database.Data.Entities.Upvote>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.UpvoteReadModel, Zeepkist.GTR.Database.Domain.Models.UpvoteUpdateModel>();

    }

}
