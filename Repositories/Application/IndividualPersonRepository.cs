using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class IndividualPersonRepository : DbRepository<IndividualPerson>, IIndividualPersonRepository
    {
        public IndividualPersonRepository(DbContext context) : base(context)
        {
        }
    }
}
