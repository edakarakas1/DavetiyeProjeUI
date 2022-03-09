using DavetiyeBusiness.Abstract;
using DavetiyeEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavetiyeWebAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DavetiyesController : ControllerBase
    {
        private IDavetiyeService davetiyeServise;
        public DavetiyesController(IDavetiyeService _davetiyeService)
        {
            davetiyeServise = _davetiyeService;
        }
        [HttpGet]
        public IActionResult GetAllDavetiye()//davetliler
        {
            var davetiyes = davetiyeServise.GetAllDavetiye();
            return Ok(davetiyes);
        }
        //[HttpGet("{id}")]
        //public IActionResult GetDavetiyeById(int id)
        //{
        //    var davetiye = davetiyeServise.GetDavetiyeById(id);
        //    if (davetiye != null)
        //    {
        //        return Ok(davetiye);
        //    }
        //    return NotFound();
        //}
        [HttpPost]
        public IActionResult CreateHotel(Davetiye davetiye)
        {
            if (ModelState.IsValid)
            {
                var createdavetiye = davetiyeServise.CreateDavetiye(davetiye);
                return Ok();
            }
            return BadRequest(ModelState);
        }
        //[HttpPut]
        //public IActionResult UpdateDavetiye(Davetiye davetiye)
        //{
        //    if (davetiyeServise.GetDavetiyeById(davetiye.Id)!=null)
        //    {
        //        davetiyeServise.UpdateDavetiye(davetiye);
        //        return Ok();
        //    }
        //    return NotFound();
        //}
        [HttpGet]
        [Route("[action]")]
        public IActionResult Gelenler(bool b)
        {
            var gelen = davetiyeServise.Gelenler(b);
            return Ok(gelen);
        }

    }
}
