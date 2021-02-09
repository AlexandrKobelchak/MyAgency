using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class TourTypeRepository : DbRepository<TourType>, ITourTypeRepository
    {
        public TourTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
