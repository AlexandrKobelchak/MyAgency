using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialNetworkController : ApiController<ISocialNetworkRepository, SocialNetwork>
    {
        public SocialNetworkController(ISocialNetworkRepository repository) : base(repository)
        {
        }
    }
}
