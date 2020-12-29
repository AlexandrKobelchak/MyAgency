using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("touristPhones")]
    public class TouristPhone:DbEntity
    {
        [Column("phone")]
        [MaxLength(32)]
        [Required]
        public string Phone { get; set; }

        [Column("sendSMS")]
        public bool IsSMS { get; set; }

        [Column("touristId")]
        public Guid TouristProfileId { get; set; }
        public TouristProfile Tourist { get; set; }
    }
}
