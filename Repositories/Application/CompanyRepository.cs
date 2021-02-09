using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class CompanyRepository : DbRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(DbContext context) : base(context)
        {
        }
    }
}
