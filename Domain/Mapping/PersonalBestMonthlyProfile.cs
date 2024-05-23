using System;
using AutoMapper;
using Zeepkist.GTR.Database.Data.Entities;
using Zeepkist.GTR.Database.Domain.Models;

namespace Zeepkist.GTR.Database.Domain.Mapping;

public partial class PersonalBestMonthlyProfile
    : AutoMapper.Profile
{
    public PersonalBestMonthlyProfile()
    {
        CreateMap<Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly, Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyReadModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyCreateModel, Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly>();

        CreateMap<Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly, Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyUpdateModel>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyUpdateModel, Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly>();

        CreateMap<Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyReadModel, Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyUpdateModel>();

    }

}
