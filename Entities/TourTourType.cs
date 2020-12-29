using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tours_ tourTypes")]
    public class TourTourType
    {
        [Column("tourTypeId")]
        public Guid TourTypeId { get; set; }
        public TourType TourType { get; set; }

        [Column("tourId")]
        public Guid TourId { get; set; }
        public Tour Tour { get; set; }
    }
}