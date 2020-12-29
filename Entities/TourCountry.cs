using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tours_countries")]
    public class TourCountry
    {
        [Column("countryId")]
        public Guid CountryId { get; set; }
        public Country Country { get; set; }

        [Column("tourId")]
        public Guid TourId { get; set; }
        public Tour Tour { get; set; }
    }
}
