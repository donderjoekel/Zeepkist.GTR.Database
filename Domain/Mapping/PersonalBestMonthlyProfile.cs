using System;
using AutoMapper;
using TNRD.Zeepkist.GTR.Database.Data.Entities;
using TNRD.Zeepkist.GTR.Database.Domain.Models;

namespace TNRD.Zeepkist.GTR.Database.Domain.Mapping;

public partial class PersonalBestMonthlyProfile
    : AutoMapper.Profile
{
    public PersonalBestMonthlyProfile()
    {
        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyReadModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyCreateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyUpdateModel>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyUpdateModel, TNRD.Zeepkist.GTR.Database.Data.Entities.PersonalBestMonthly>();

        CreateMap<TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyReadModel, TNRD.Zeepkist.GTR.Database.Domain.Models.PersonalBestMonthlyUpdateModel>();

    }

}
