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
        public TouristProfile profile { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PassportSerial { get; set; }
        public string PassportNumber { get; set; }
        public string PassportDistributor { get; set; }
        public string PassportDate { get; set; }
    }
}
