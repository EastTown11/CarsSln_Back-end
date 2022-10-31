using CarsSln.Service.CarModelsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarsSln.Service.CarModelsService.CarModelsService;

namespace CarsSln.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly ICarModelServices _service;
        public ModelController(ICarModelServices service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("~/GeTAllModel")]
        public IActionResult GeTAllModel()
        {
            return Ok(_service.GeTAll());
        }
        [HttpGet]
        [Route("~/GeTModelByID/{ModelId:int}")]
        public IActionResult GeTModelByID(int ModelId)
        {
            return Ok(_service.CarModelByID(ModelId));

        }
        [HttpPost]
        [Route("~/PostCarModel")]
        public IActionResult PostCarModel(ModelsList _models)
        {
            var Post = _service.PostModel(_models);
            if (Post == null) return NotFound();
            return Ok(Post);
        }
        [HttpPut]
        [Route("~/UpdateCarModel")]
        public IActionResult UpdateCarModel(ModelsList _models)
        {
            var Update = _service.UpdateModel(_models);
            if (Update == null) return NotFound();
            return Ok(Update);
        }
        [HttpDelete]
        [Route("~/DeleteCarModel/{ModelId:int}")]
        public IActionResult DeleteCarModel(int ModelId)
        {
            var Delete = _service.DeleteCarModel(ModelId);
            if (Delete == null) return NotFound();
            return Ok(Delete);

        }

    }
}
