using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristProfileController : ApiController<ITouristProfileRepository, TouristProfile>
    {
        public TouristProfileController(ITouristProfileRepository repository) : base(repository)
        {
        }
    }
   
}
