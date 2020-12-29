using Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("banks")]
    public class Bank : DbEntity
    {
        [Column("name")]
        [MaxLength(128)]
        [Required]
        public string Name { get; set; }
        
        [Column("mfo")]
        [Required]
        public uint MFO { get; set; }

        [Column("city")]
        [MaxLength(16)]
        [Required]
        public string City { get; set; }

        public List<Company> Companies { get; set; }
        public List<LegalPerson> LegalPersons { get; set; }
    }
}
