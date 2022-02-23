using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Entities
{
    public class TripEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Depart { get; set; }
        [Required]
        public string Arrivel { get; set; }
        [Required]
        public string DateDepart { get; set; }
        [Required]
        public int NbrPlaces { get; set; }
        [ForeignKey("StopsId ")]
        public int StopsId { set; get; }
        public ICollection<StopsEntity> Stops { set; get; } = new List<StopsEntity>();
        public string Commentaire { get; set; }
        public int Note { get; set; }
        [ForeignKey("BusId")]
        public int BusId { get; set; }
        public BusEntity Bus { get; set; }
    }
}
