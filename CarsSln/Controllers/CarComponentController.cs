using CarsSln.Service.CarComponentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarsSln.Service.CarComponentService.CarComponentService;

namespace CarsSln.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarComponentController : ControllerBase
    {
        ICarComponentService _ICarComponentService;
        public CarComponentController(ICarComponentService service)
        {
            _ICarComponentService = service;
        }
        [HttpGet]
        [Route("~/GetCarComponentList")]
        public IActionResult GetCarComponentList()
        {
            try
            {
                var _CarComponent = _ICarComponentService.GetCarComponentList();
                if (_CarComponent == null) return NotFound();
                return Ok(_CarComponent);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("~/getComponentId/{ComponentId:int}")]
        public IActionResult getCarComponentId(int ComponentId)
        {
            try
            {
                var _CarComponent = _ICarComponentService.GetCarComponentId(ComponentId);
                if (_CarComponent == null) return NotFound();
                return Ok(_CarComponent);
                return null;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/saveCarComponent")]
        public IActionResult saveCarComponent([FromBody] CarComponentList CarListModel)
        {
            try
            {
                var model = _ICarComponentService.SaveCarComponent(CarListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("~/updateCarComponent")]
        public IActionResult updateCarComponent([FromBody] CarComponentList CarListModel)
        {
            try
            {
                var model = _ICarComponentService.updateCarComponent(CarListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("~/DeleteCarComponent/{ComponentId:int}")]
        public IActionResult DeleteCarComponent(int ComponentId)
        {
            try
            {
                var model = _ICarComponentService.DeleteCarComponent(ComponentId);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }



    }
}
