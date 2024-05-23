using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class PersonalBestYearlyProfile
    : AutoMapper.Profile
{
    public PersonalBestYearlyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyUpdateModel>();

    }

}
