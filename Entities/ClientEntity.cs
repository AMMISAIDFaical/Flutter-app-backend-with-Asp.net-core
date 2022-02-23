using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusAppBackend.Entities
{
    public class ClientEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string  name { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        [MaxLength(20)]
        public string email { get; set; }
        [MaxLength(8)]
        public string phoneNumber { get; set; }
        [Required]
        public string password { get; set; }
        public char gender { get; set; }
    }
}
