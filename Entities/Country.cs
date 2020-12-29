using Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("countries")]
    public class Country: DbEntity
    {
        [Column("name")]
        [MaxLength(128)]
        [Required]
        public string Name { get; set; }
        public List<TourCountry> CountryTour { get; set; }  
        public List<Tour> Tours { get; set; }
    }
}
