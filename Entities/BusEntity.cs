using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Entities
{
    public class BusEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public string marque { get; set; }
        [Required]
        [MaxLength(50)]
        public string model { get; set; }
        [Required]
        public string year { get; set; }
        [Required]
        public int nbrSeats { get; set; }
        public ICollection<BusImgUrlEntity> BusImgUrlEntity { get; set; } = new List<BusImgUrlEntity>();
        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        public CompanyEntity Company { get; set; }
    }
}
