using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Models
{
    public class BusModel
    {
        public int id { get; set; }
        public string marque { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int nbrSeats { get; set; }
        public int CompanyId { get; set; }
        public ICollection<string> images{ set; get; }
               = new List<string>();
    }
}
