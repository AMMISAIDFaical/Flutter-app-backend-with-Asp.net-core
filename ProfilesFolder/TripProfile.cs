using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.ProfilesFolder
{
    public class TripProfile : Profile  
    {
        public TripProfile()
        {
            CreateMap<Entities.TripEntity, Models.TripModel>();
            CreateMap<Models.TripModel, Entities.TripEntity>();
        }
    }
}
