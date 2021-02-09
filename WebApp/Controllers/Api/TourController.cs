using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourController : ApiController<ITourRepository, Tour>
    {
        public TourController(ITourRepository repository) : base(repository)
        {
        }
    }
   
}
