using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualPersonController : ApiController<IIndividualPersonRepository, IndividualPerson>
    {
        public IndividualPersonController(IIndividualPersonRepository repository) : base(repository)
        {
        }
    }
   
}
