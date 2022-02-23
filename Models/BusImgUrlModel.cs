using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Models
{
    public class BusImgUrlModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int BusEntityId { get; set; }
    }
}
