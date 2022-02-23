using BusAppBackend.Context;
using BusAppBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Services
{ 
    public class ReservationRepo : IReservationRepo
    {
        private readonly BbaContext _context;
        public ReservationRepo(BbaContext context)
        {
            _context = context;
        }

        public void AddReservation(ReservationEntity reservation)
        {
            _context.ReservationEntity.Add(reservation);
        }

        public void DeleteReservation(ReservationEntity reservation)
        {
            _context.ReservationEntity.Remove(reservation);
        }

        public ReservationEntity GetReservationByClientId(int Client_id)
        {
            return _context.ReservationEntity.Where(r => r.ClientId == Client_id).FirstOrDefault();
        }

        public ReservationEntity GetReservationById(int id)
        {
            return _context.ReservationEntity.Where(r => r.Id== id).FirstOrDefault();
        }

        public ReservationEntity GetReservationByTripId(int Trip_id)
        {
            return _context.ReservationEntity.Where(r => r.TripId == Trip_id).FirstOrDefault();
        }

        public IEnumerable<ReservationEntity> GetReservations()
        {
            return _context.ReservationEntity.ToList();
        }

        public bool Save()
        {
                return _context.SaveChanges() >= 0;
        }
    }
}
