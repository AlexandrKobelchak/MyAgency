using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class TouristProfileRepository : DbRepository<TouristProfile>, ITouristProfileRepository
    {
        public TouristProfileRepository(DbContext context) : base(context)
        {
        }
    }
}
