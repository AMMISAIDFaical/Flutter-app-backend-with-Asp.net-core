using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Entities
{
    public class BusImgUrlEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        [ForeignKey("BusEntityId")]
        public int BusEntityId { get; set; }
        public BusEntity Bus{ get; set; }
    }
}
