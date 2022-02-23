using BusAppBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Services
{
    public interface ITripRepo
    {
        TripEntity GetTripById(int id);
        TripEntity GetTrip(string depart ,string arriver, string date);
        TripEntity GetTripByBus(int Busid);
        TripEntity GetTripByCord(string depart, string arrival);
        IEnumerable<TripEntity> GetTrips();
        void AddTrip(TripEntity trip);
        bool Save();
        void DeleteTrip(TripEntity trip);
        StopsEntity GetStopsById(int Tripid);
        
    }
}
