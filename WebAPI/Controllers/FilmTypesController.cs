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
    public class FilmTypesController : ControllerBase
    {
        IFilmTypeService _filmTypeService;

        public FilmTypesController(IFilmTypeService filmTypeService)
        {
            _filmTypeService = filmTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _filmTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _filmTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(FilmType filmType)
        {
            var result = _filmTypeService.Add(filmType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(FilmType filmType)
        {
            var result = _filmTypeService.Delete(filmType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(FilmType filmType)
        {
            var result = _filmTypeService.Update(filmType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
