using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Models
{
    public class ReservationModel
    {

        public int Id { get; set; }
        public string Status { get; set; }
        public int ClientId { get; set; }
        public int TripId { get; set; }
    }
}
