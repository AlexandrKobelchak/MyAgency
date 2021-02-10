using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialController : ApiController<ISocialNetworkRepository, SocialNetwork>
    {
        public SocialController(ISocialNetworkRepository repository) : base(repository)
        {
        }
    }
}
