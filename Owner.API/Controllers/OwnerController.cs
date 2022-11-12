using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Owner.API.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;

namespace Owner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Models.Owner))]
        [HttpGet("AllOwners")]
        public IActionResult GetOwners()
        {
            var ownerDatas = new OwnerData().GetAllOwners();
            return Ok(ownerDatas);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Models.Owner))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Models.Owner))]
        [Consumes("application/json")]
        [HttpPost("Create")]
        public IActionResult AddOwner(Models.Owner model)
        {
            if (model == null)
                return BadRequest();

            if (model.Description.ToLower().Contains("hack"))
                return BadRequest("Description cannot contain \"hack\" phrase.");

            var owner = new List<Models.Owner>();
            owner.Add(model);
            return Ok(model);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Models.Owner))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id:int}")]
        public IActionResult UpdateOwner(int id, Models.Owner owner)
        {
            if (id != owner.Id)
                return BadRequest("Owner Id's did not match.");

            var owners = new OwnerData().GetAllOwners();

            var update = owners.FirstOrDefault(x => x.Id == id);

            if (update != null)
            {
                update.Name = owner.Name;
                update.Surname = owner.Surname;
                update.Date = owner.Date;
                update.Description = owner.Description;
                update.Type = owner.Type;

                return Ok(update);
            }
            else
            {
                return BadRequest("This id has no owners.");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Models.Owner))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id:int}")]
        public IActionResult DeleteOwner(int id)
        {
            var owners = new OwnerData().GetAllOwners();

            var owner = owners.FirstOrDefault(x => x.Id == id);

            if (owner == null)
                return NotFound($"Owner {id} not found.");

            owners.Remove(owner);

            return Ok($"Owner {id} successfully deleted.");
        }
    }
}
