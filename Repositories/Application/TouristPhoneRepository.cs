using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class TouristPhoneRepository : DbRepository<TouristPhone>, ITouristPhoneRepository
    {
        public TouristPhoneRepository(DbContext context) : base(context)
        {
        }
    }
}
