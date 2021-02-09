using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{

    [Table("sales")]
    public class Sale: DbEntity
    {
        public TouristProfile Tourist { get; set; }
        public Employee Agent { get; set; }
        public Tour Tour { get; set; }
        
        [Column("beginDate")]
        public DateTime BeginDate { get; set; }

        [Column("duration")]
        public int Duration { get; set; }

        [MaxLength(512)]
        [Column("description")]
        public string Description { get; set; }

        [Column("touristId")]
        public Guid TouristId { get; set; }

        [Column("agentId")]
        public Guid AgentId { get; set; }

        [Column("tourId")]
        public Guid TourId { get; set; }
    }
}
