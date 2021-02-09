using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController<TRepository, TEntity> : ControllerBase
        where TRepository : IDbRepository<TEntity>
        where TEntity : class, IDbEntity
    {

        TRepository _repository;
        public ApiController(TRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public virtual async Task<IEnumerable<TEntity>> Get()
        {
            return await _repository.ToListAsync();
        }
        [HttpGet("{id}")]
        public virtual async Task<TEntity> Get(Guid id)
        {
            return await _repository.GetItemAsync(id);
        }
        [HttpPost]
        public virtual async Task<ActionResult> Post(TEntity faculty)
        {
            if (await _repository.AddItemAsync(faculty))
            {
                return new StatusCodeResult(200);
            }
            else
                return new StatusCodeResult(500);
        }

        [HttpPut]
        public virtual async Task<ActionResult> Put(TEntity faculty)
        {
            if (await _repository.UpdateItemAsync(faculty))
            {
                return new StatusCodeResult(200);
            }
            else
                return new StatusCodeResult(500);
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(Guid id)
        {
            if (await _repository.DeleteItemAsync(id))
            {
                return new StatusCodeResult(200);
            }
            else
                return new StatusCodeResult(500);
        }
    }
}

