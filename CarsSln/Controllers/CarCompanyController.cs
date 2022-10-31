using CarsSln.Service.CarCompanyService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarsSln.Service.CarCompanyService.CarCompanyService;

namespace CarsSln.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarCompanyController : ControllerBase
    {
        ICarCompanyService _ICarCompanyService;
        public CarCompanyController (ICarCompanyService service)
        {
            //llll
            _ICarCompanyService = service;
        }
        [HttpGet]
        [Route("~/CarCompany")]
        public IActionResult GetCarCompanyList()
        {
            try
            {
                var _CarCompany = _ICarCompanyService.GetCarCompanyList();
                if (_CarCompany == null) return NotFound();
                return Ok(_CarCompany);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("~/GetCarCompanyId/{CarCompanyId:int}")]
        public IActionResult GetCarCompanyId(int CarCompanyId)
        {
            try
            {
                var _CarCompany = _ICarCompanyService.GetCarCompanyId(CarCompanyId);
                if (_CarCompany == null) return NotFound();
                return Ok(_CarCompany);
                return null;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/SaveCarCompany")]
        public IActionResult SaveCarCompany([FromBody] CarCompanylist CarListModel)
        {
            try
            {
                var model = _ICarCompanyService.SaveCarCompany(CarListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("~/updateCarCompany")]
        public IActionResult updateCarCompany([FromBody] CarCompanylist CarListModel)
        {
            try
            {
                var model = _ICarCompanyService.updateCarCompany(CarListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("~/DeleteCarCompany/{CarCompanyId:int}")]
        public IActionResult DeleteCarInfo(int CarCompanyId)
        {
            try
            {
                var model = _ICarCompanyService.DeleteCarCompany(CarCompanyId);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }





    }
}
