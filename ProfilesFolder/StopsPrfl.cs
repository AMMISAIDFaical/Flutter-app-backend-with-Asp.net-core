using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.ProfilesFolder
{
    public class StopsPrfl : Profile
    {
        public StopsPrfl()
        {
            CreateMap<Entities.StopsEntity,Models.StopModel>();
            CreateMap<Models.StopModel,Entities.StopsEntity>();
        }
    }
}
