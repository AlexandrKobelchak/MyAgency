using Domain;
using System.Collections.Generic;


namespace Entities
{
    public class Bank : DbEntity
    {
        public string Name { get; set; }
        public uint MFO { get; set; }
        public string City { get; set; }

        public virtual List<Company> Companies { get; set; }
    }
}
