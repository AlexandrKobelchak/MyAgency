using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class BankRepository : DbRepository<Bank>, IBankRepository
    {
        public BankRepository(DbContext context) : base(context)
        {
        }
    }
}
