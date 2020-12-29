using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("EmployeeRole")]
    public class EmployeeRole : DbEntity
    {
        public string Name { get; set; }       
        public virtual List<Employee> Employees { get; set; }
        public virtual List<EmployeePermissionRole> PermissionEmployeeRole { get; set; }
    }
}
