using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristTagController : ApiController<ITouristTagRepository, TouristTag>
    {
        public TouristTagController(ITouristTagRepository repository) : base(repository)
        {
        }
    }
}
