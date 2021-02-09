using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class EmployeeRepository : DbRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context)
        {
        }
    }
}
