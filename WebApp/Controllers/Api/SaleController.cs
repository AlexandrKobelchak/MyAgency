using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ApiController<ISaleRepository, Sale>
    {
        public SaleController(ISaleRepository repository) : base(repository)
        {
        }
    }
   
}
