using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("touristProfiles")]
    public class TouristProfile : DbEntity
    {
        [Column("firstName")]
        [MaxLength(128)]
        [Required]
        public string FirstName { get; set; }

        [Column("lastName")]
        [MaxLength(128)]
        [Required]
        public string LastName { get; set; }

        [Column("middleName")]
        [MaxLength(128)]
        public string MiddleName { get; set; }

        [Column("comment")]
        [MaxLength(512)]
        [Required]
        public string Comment { get; set; }

        [Column("email")]
        [MaxLength(128)]       
        public string EMail { get; set; }

        [Column("noSendStatus")]
        public bool NoSendStatus { get; set; }

        [Column("noSendNews")]
        public bool NoSendNewslatter { get; set; }

        [Column("city")]
        [MaxLength(64)]
        [Required]
        public string City { get; set; }

        [Column("address")]
        [MaxLength(256)]
        [Required]
        public string Address { get; set; }

        [Column("birthday")]        
        public DateTime Birthday { get; set; }

        public List<TouristPhone> Phones { get; set; }


        public List<TouristProfileTag> ProfileTouristTag { get; set; }
        public List<TouristTag> TouristTags { get; set; }


        public LegalPerson LegalPersonData { get; set; }
        public IndividualPerson IndividualPersonData { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
