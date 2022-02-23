using BusAppBackend.Context;
using BusAppBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Services
{
    public class TripRepo : ITripRepo
    {
        private readonly BbaContext _context;
        public TripRepo(BbaContext  context)
        {
            _context = context;
        }

        public TripEntity GetTrip(int id)
        {
            return _context.TripsEntity.Where(t => t.Id == id).FirstOrDefault();
        }

        public IEnumerable<TripEntity> GetTrips()
        {
            return _context.TripsEntity.ToList();
        } 

        TripEntity ITripRepo.GetTrip(string depart, string arriver, string date)
        {
        return _context.TripsEntity.Where(t => t.Depart == depart && t.Arrivel == arriver && t.DateDepart == date).FirstOrDefault();
        }

        TripEntity ITripRepo.GetTripByBus(int Busid)
        {
            return _context.TripsEntity.Where(t => t.BusId == Busid).FirstOrDefault();
        }

        TripEntity ITripRepo.GetTripById(int id)
        {
            return _context.TripsEntity.Where(t => t.Id == id).FirstOrDefault();
        }

        public void AddTrip(TripEntity trip)
        {
            _context.TripsEntity.Add(trip);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0; 
        }

        public void DeleteTrip(TripEntity trip)
        {
            _context.TripsEntity.Remove(trip);
        }

        public StopsEntity GetStopsById(int stopId)
        {

            return _context.StopsEntity.Where(s => s.Id == stopId).FirstOrDefault();
        }

        public TripEntity GetTripByCord(string depart, string arrival)
        {
            return _context.TripsEntity.Where
                (t => t.Depart == depart && t.Arrivel == arrival).FirstOrDefault();
        }
    }
}
