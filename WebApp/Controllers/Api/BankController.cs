using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ApiController<IBankRepository, Bank>
    {
        public BankController(IBankRepository repository) : base(repository)
        {
        }
    }
}
