using BusAppBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Services
{
    public interface IBusRepo
    {
        BusImgUrlEntity GetImgUrlByBusId(int BusId);

        IEnumerable<BusEntity> Getbuses();

        BusEntity GetBus(int id);

        BusEntity GetBusByModel(string model);
        
        BusEntity GetBusByNbrSeats(int nbrSeats);

        void AddBus(BusEntity bus);

        void AddBusImg(BusImgUrlEntity busImg);

        bool Save();

        void Delete(BusEntity bus);

    }
}
