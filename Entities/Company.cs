using Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("compaties")]
    public class Company : DbEntity
    {
        [Column("name")]
        [MaxLength(128)]
        [Required]
        public string Name { get; set; }

        [Column("address")]
        [MaxLength(256)]
        [Required]
        public string Address { get; set; }

        public virtual List<Employee> Emploiees { get; set; }
    }

  
}
