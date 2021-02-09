using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ApiController<ICountryRepository, Country>
    {
        public CountryController(ICountryRepository repository) : base(repository)
        {
        }
    }
   
}
