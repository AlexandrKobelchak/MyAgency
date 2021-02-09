using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class LegalPersonRepository : DbRepository<LegalPerson>, ILegalPersonRepository
    {
        public LegalPersonRepository(DbContext context) : base(context)
        {
        }
    }
}
