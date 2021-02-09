using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourTypeController : ApiController<ITourTypeRepository, TourType>
    {
        public TourTypeController(ITourTypeRepository repository) : base(repository)
        {
        }
    }
   
}
