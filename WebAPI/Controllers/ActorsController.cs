using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        IActorService _actorService;

        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;
        }

        [HttpPost("add")]
        public IActionResult Add(Actor actor)
        {
            var result = _actorService.Add(actor);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
