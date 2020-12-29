using Domain;
using System;


namespace Entities
{
    public class Sale: DbEntity
    {
        public virtual TouristProfile Tourist { get; set; }
        public virtual Employee Agent { get; set; }
        public virtual Tour Tour { get; set; }
        public DateTime BeginDate { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
    }
}
