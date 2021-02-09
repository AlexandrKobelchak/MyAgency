using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TourRepository : DbRepository<Tour>, ITourRepository
    {
        public TourRepository(DbContext context) : base(context)
        {
        }
    }
}
