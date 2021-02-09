using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SocialNetwork:DbEntity
    {
        public string Name { get; set; }
        public List<TouristPhoneSocial> TPS { get; set; }
        public List<TouristPhone> TouristPhones { get; set; }
    }
}
