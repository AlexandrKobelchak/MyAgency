using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LegalPersonController : ApiController<ILegalPersonRepository, LegalPerson>
    {
        public LegalPersonController(ILegalPersonRepository repository) : base(repository)
        {
        }
    }
   
}
