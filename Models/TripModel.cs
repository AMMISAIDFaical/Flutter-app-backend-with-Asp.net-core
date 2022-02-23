using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Models
{
    public class TripModel
    {
        public int Id { get; set; }
        public string Depart { get; set; }
        public string Arrivel { get; set; }
        public string DateDepart { get; set; }
        public int NbrPlaces { get; set; }
        public ICollection<string> Stops { set; get; } = new List<string>();
        public int StopId { get; set; }
        public string Commentaire { get; set; }
        public int Note { get; set; }
        public int BusId { get; set; }
    }                                   
}
