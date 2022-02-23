using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.ProfilesFolder
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Entities.ClientEntity, Models.ClientModel>();
            CreateMap<Models.ClientModel,Entities.ClientEntity > ();
        }
    }
}
