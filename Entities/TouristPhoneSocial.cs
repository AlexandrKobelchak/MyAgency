using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class TouristPhoneSocial
    {
        public TouristPhone TouristPhone { get; set; }
        public SocialNetwork SocialNetwork { get; set; }

        public Guid PhoneId { get; set; }
        public Guid SocialId { get; set; }
    }
}
