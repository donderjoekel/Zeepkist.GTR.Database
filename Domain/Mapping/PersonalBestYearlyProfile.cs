using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class PersonalBestYearlyProfile
    : AutoMapper.Profile
{
    public PersonalBestYearlyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly, Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyCreateModel, Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly, Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyUpdateModel, Zeepkist.GTR.Database.Data.Entities.PersonalBestYearly>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyReadModel, Zeepkist.GTR.Database.Domain.Models.PersonalBestYearlyUpdateModel>();

    }

}
