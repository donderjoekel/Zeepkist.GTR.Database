using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class PersonalBestWeeklyProfile
    : AutoMapper.Profile
{
    public PersonalBestWeeklyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly, Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyCreateModel, Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly, Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyUpdateModel, Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyReadModel, Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyUpdateModel>();

    }

}
