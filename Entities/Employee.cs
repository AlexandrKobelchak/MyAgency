using Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("Employees")]
    public class Employee: IdentityUser
    {
       
        //public IdentityUser User { get; set; }

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

        public Company Company { get; set; }
        
        [Column("companyId")]
        public Guid CompanyId { get; set; }
      
        public List<Sale> Sales { get; set; }
    }
}
