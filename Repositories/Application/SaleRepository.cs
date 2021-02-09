using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class SaleRepository : DbRepository<Sale>, ISaleRepository
    {
        public SaleRepository(DbContext context) : base(context)
        {
        }
    }
}
