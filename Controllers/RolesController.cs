using Hostels.Models;
using Hostels.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hostels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
       private readonly IRolesService _service;
        public RolesController(IRolesService service)
        {
            _service = service;
        }


        // GET: api/<RolesController>
        [HttpGet]
        public IEnumerable<Roles> Get()
        {
            return _service.GetRoles();
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public List<Roles> Get(int id)
        {
            return _service.GetRoleById(id).ToList();
        }

        // POST api/<RolesController>
        [HttpPost]
        public Task<string> Post([FromBody] Roles value)
        {
            return _service.PostRoles(value);
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public Task<string> Put(int id, [FromBody] Roles value)
        {
            return _service.PutRoles(id, value);
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public Task<string> Delete(int id)
        {
            return _service.DeleteRole(id);
        }
    }
}
