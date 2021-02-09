using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ApiController<IEmployeeRepository, Employee>
    {
        public EmployeeController(IEmployeeRepository repository) : base(repository)
        {
        }
    }
   
}
