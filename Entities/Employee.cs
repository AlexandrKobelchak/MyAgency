using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("Employees")]
    public class Employee: DbEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Company Company { get; set; }
        public EmployeeRole EmployeeRole { get; set; }

        public Guid CompanyId { get; set; }
        public Guid EmployeeRoleId { get; set; }
    }
}
