using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class CountryRepository : DbRepository<Country>, ICountryRepository
    {
        public CountryRepository(DbContext context) : base(context)
        {
        }
    }
}
