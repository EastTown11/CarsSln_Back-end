using CarsSln.Service.CarTypeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarTypeService;

namespace CarsSln.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTypeController : ControllerBase
    {
        private readonly ICarTypeService _service;
        public CarTypeController(ICarTypeService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("~/GetALL")]
        public IActionResult GetALL()
        {
            try
            {
                var GetAll = _service.GetAll();
                if (GetAll == null) return NotFound();
                return Ok(GetAll);
            }
            catch (Exception)
            {

                return BadRequest();

            }
        }
        [HttpGet]
        [Route("~/GetCarTypeByid/{TypeId:int}")]
        public IActionResult GetCarTypeByid(int TypeId)
        {
            try
            {
                var id = _service.GetTypeByid(TypeId);
                if (id == null) return NotFound();
                return Ok(id);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/PostTypeCar")]
        public IActionResult PostTypeCar(ListCartype _cartype)
        {
            try
            {
                var Model = _service.PostCarType(_cartype);
                if (Model == null) return NotFound();
                return Ok(Model);

            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
        [HttpPut]
        [Route("~/UpdateCarType")]
        public IActionResult UpdateCarType(ListCartype _cartype)
        {
            try
            {
                var Update = _service.UpdateCartype(_cartype);
                if (Update == null) return NotFound();
                return Ok(Update);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("~/DeleteCarType/{TypeId:int}")]
        public IActionResult DeleteCarType(int TypeId)
        {
            try
            {
                var Delete = _service.DeleteCarType(TypeId);
                if (Delete == null) return NotFound();
                return Ok(Delete);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
