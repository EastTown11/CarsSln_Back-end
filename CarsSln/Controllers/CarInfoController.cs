using CarsSln.Service.CarInfoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarsSln.Service.CarInfoService.CarInfoService;

namespace CarsSln.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarInfoController : ControllerBase
    {

        ICarInfoService _ICarInfoService;
        public CarInfoController(ICarInfoService service)
        {
            _ICarInfoService = service;
        }
        [HttpGet]
        [Route("~/GetCarInfoList")]
        public IActionResult GetCarInfoList()
        {
            try
            {
                var _CarInfo = _ICarInfoService.GetCarInfoList();
                if (_CarInfo == null) return NotFound();
                return Ok(_CarInfo);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/GetCarInfoById/{CarInfoId:int}")]
        public IActionResult GetCarInfoById(int CarInfoId)
        {
            try
            {
                var _CarInfo = _ICarInfoService.GetCarInfoById(CarInfoId);
                if (_CarInfo == null) return NotFound();
                return Ok(_CarInfo);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("~/SaveCarInfo")]
        public IActionResult SaveCarInfo([FromBody] CarList CarListModel)
        {
            try
            {
                var model = _ICarInfoService.SaveCarInfo(CarListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("~/updateEduSubject")]
        public IActionResult updateEduSubject([FromBody] CarList CarListModel)
        {
            try
            {
                var model = _ICarInfoService.updateCarInfo(CarListModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("~/DeleteCarInfo/{CarInfoId:int}")]
        public IActionResult DeleteCarInfo(int CarInfoId)
        {
            try
            {
                var model = _ICarInfoService.DeleteCarInfo(CarInfoId);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }





    }
}
