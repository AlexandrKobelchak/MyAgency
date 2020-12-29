using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tourists_tags")]
    public class TouristProfileTag
    {
        [Column("touristId")]
        public Guid TouristId { get; set; }
        public TouristProfile TouristProfile { get; set; }

        [Column("tagId")]
        public Guid TagId { get; set; }
        public TouristTag TouristTag { get; set; }
    }
}
