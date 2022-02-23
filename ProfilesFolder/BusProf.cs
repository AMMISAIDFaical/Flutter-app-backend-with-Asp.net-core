using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.ProfilesFolder
{
    public class BusProf : Profile
    {
        public BusProf()
        {
            CreateMap<Entities.BusEntity, Models.BusModel>();
            CreateMap<Models.BusModel,Entities.BusEntity>();
            CreateMap<Models.BusImgUrlModel, Entities.BusImgUrlEntity>();
            CreateMap<Entities.BusImgUrlEntity,Models.BusImgUrlModel>();
        }
    }
}
