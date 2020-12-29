using Domain;
using System.Collections.Generic;

namespace Entities
{
    public class Company : DbEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual List<Employee> Emploiees { get; set; }
    }

  
}
