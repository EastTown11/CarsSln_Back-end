using CarsSln.Service.ColorCarService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarsSln.Service.ColorCarService.CarColorService;

namespace CarsSln.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarColorController : ControllerBase
    {
        ICarColorService _ICarColorService;
        public CarColorController(ICarColorService service)
        {
            _ICarColorService = service;
        }
        [HttpGet]
        [Route("~/GetCarColor")]
        public IActionResult GetCarColor()
        {
            try
            {
                var _CarColor = _ICarColorService.GetCarColorList().ToList();
                if (_CarColor == null) return NotFound();
                return Ok(_CarColor);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/getCarColorByid/{colorid:int}")]
        public IActionResult getCarColorByid(int colorid)
        {
            try
            {
                var _color = _ICarColorService.GetcolorByid(colorid);
                if (_color == null) return NotFound();
                return Ok(_color);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/PostColor")]
        public IActionResult PostColor(ListColor listColor)
        {
            try
            {
                var Post = _ICarColorService.PostColor(listColor);
                if (Post == null) return NotFound();
                return Ok(Post);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("~/UpdateColor")]
        public IActionResult UpdateColor(ListColor listColor)
        {
            try
            {
                var Update = _ICarColorService.UpdateColor(listColor);
                if (Update == null) return NotFound();
                return Ok(Update);
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
        [HttpDelete]
        [Route("~/deleteColor/{colorid:int}")]
        public IActionResult deleteColor(int colorid)
        {
            try
            {
                var Deltee = _ICarColorService.DeleteColor(colorid);
                if (Deltee == null) return NotFound();
                return Ok(Deltee);
            }
            catch (Exception)
            {

                return BadRequest();
            } 
        }



    }
}
