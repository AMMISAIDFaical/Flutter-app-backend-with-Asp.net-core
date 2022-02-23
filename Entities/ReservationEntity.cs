using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Entities
{
    public class ReservationEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required()]
        public string Status { get; set; }
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        public ClientEntity Client { get; set; }
        [ForeignKey("TripId")]
        public int TripId { get; set; }
        public TripEntity Trip { get; set; }
    }
}
