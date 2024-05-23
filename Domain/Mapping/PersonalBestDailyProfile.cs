using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class PersonalBestDailyProfile
    : AutoMapper.Profile
{
    public PersonalBestDailyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily, Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyCreateModel, Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily, Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyUpdateModel, Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyReadModel, Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyUpdateModel>();

    }

}
