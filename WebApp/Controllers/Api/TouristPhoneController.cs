using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristPhoneController : ApiController<ITouristPhoneRepository, TouristPhone>
    {
        public TouristPhoneController(ITouristPhoneRepository repository) : base(repository)
        {
        }
    }
   
}
