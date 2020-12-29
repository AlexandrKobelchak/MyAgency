using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("EmployeePermission")]
    public class EmployeePermission:DbEntity
    {
         public string PermissionName { get; set; }
         public List<EmployeePermissionRole> PermissionEmployeeRole { get; set; }
    }

    public class EmployeePermissionRole
    {
        public Guid EmployeeRoleId { get; set; }
        public EmployeeRole EmployeeRole { get; set; }

        public Guid PermissionId { get; set; }
        public EmployeePermission Permission { get; set; }
    }


}
