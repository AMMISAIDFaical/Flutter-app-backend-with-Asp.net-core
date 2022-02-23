using BusAppBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Services
{
    public interface IReservationRepo
    {
        ReservationEntity GetReservationById(int id);
        ReservationEntity GetReservationByClientId(int Client_id);
        ReservationEntity GetReservationByTripId(int Trip_id);
        IEnumerable<ReservationEntity> GetReservations();
        void AddReservation(ReservationEntity reservation);
        bool Save();
        void DeleteReservation(ReservationEntity reservation);
    }
}
