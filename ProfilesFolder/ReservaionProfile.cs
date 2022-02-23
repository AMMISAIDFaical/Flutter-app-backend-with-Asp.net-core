using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.ProfilesFolder
{
    public class ReservaionProfile : Profile
    {
        public ReservaionProfile()
        {
            CreateMap<Entities.ReservationEntity, Models.ReservationModel>();
            CreateMap<Models.ReservationModel,Entities.ReservationEntity>();
        }
    }
}
