using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class SocialNetworkRepository : DbRepository<SocialNetwork>, ISocialNetworkRepository
    {
        public SocialNetworkRepository(DbContext context) : base(context)
        {
        }
    }
}
