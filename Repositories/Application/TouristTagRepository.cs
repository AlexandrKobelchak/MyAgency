using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class TouristTagRepository : DbRepository<TouristTag>, ITouristTagRepository
    {
        public TouristTagRepository(DbContext context) : base(context)
        {
        }
    }
}
