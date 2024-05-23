using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class PersonalBestDailyProfile
    : AutoMapper.Profile
{
    public PersonalBestDailyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestDaily>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestDailyUpdateModel>();

    }

}
