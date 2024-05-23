using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class PersonalBestWeeklyProfile
    : AutoMapper.Profile
{
    public PersonalBestWeeklyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestWeekly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestWeeklyUpdateModel>();

    }

}
