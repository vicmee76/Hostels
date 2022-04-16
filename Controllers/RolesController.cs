using Hostels.Interfaces;
using Hostels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        IRoles _roles;

        public RolesController(IRoles roles)
        {
            _roles = roles;
        }


        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] Roles role)
        {
            try
            {
                var result = await _roles.PostRoles(role);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // GET: api/<RolesController>
        [HttpGet]
        public IEnumerable<Roles> Get()
        {
            return _roles.GetRoles();
        }


        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public List<Roles> Get(int id)
        {
            return _roles.GetRoleById(id).ToList();
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<string>> Put(int id, [FromBody] Roles value)
        {
            try
            {
                var r = await _roles.PutRoles(id, value);
                return Ok(r);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<RolesController>/5

        [HttpDelete("{id}")]
        public Task<string> Delete(int id)
        {
            return _roles.DeleteRole(id);
        }
    }
}
