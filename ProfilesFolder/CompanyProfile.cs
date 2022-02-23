using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.ProfilesFolder
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Entities.CompanyEntity, Models.CompanyModel>();
            CreateMap<Models.CompanyModel,Entities.CompanyEntity>();
        }
    }
}
