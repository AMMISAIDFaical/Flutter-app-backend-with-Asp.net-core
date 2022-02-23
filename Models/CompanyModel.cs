using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Wilaya { get; set; }
        public string Adress { get; set; }
        public ICollection<string> Buses { get; set; } = new List<string>();
    }
}
