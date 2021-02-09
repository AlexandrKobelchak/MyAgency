using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ApiController<ICompanyRepository, Company>
    {
        public CompanyController(ICompanyRepository repository) : base(repository)
        {
        }
    }
   
}
