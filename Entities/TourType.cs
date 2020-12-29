using Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tourTypes")]
    public class TourType : DbEntity
    {
        [Column("name")]
        [MaxLength(128)]
        [Required]
        public string TypeName { get; set; }
        public List<TourTourType> TourTourType { get; set; }
        public List<Tour> Tours { get; set; }
    }   
}