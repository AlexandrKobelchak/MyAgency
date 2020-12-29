using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class IndividualPerson : IDbEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        public TouristProfile Profile { get; set; }
        
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

        [Column("passportSerial")]
        [MaxLength(16)]
        public string PassportSerial { get; set; }

        [Column("passportNumber")]
        [MaxLength(16)]
        public string PassportNumber { get; set; }

        [Column("passportDistributor")]
        [MaxLength(16)]
        public string PassportDistributor { get; set; }

        [Column("passportMakeDate")]        
        public DateTime PassportMakeDate { get; set; }

        [Column("passportExpiredDate")]
        public DateTime PassportExpiredDate { get; set; }
    }
}
