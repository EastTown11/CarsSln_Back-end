using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarsSln.Service.CarModelsService.CarModelsService;

namespace CarsSln.Service.CarModelsService
{
   public  interface ICarModelServices
    {
         List<CarModel> GeTAll();
        List<CarModel> PostModel(ModelsList _models);
        CarModel CarModelByID(int ModelId);
        List<CarModel> UpdateModel(ModelsList modelsList);
        ResponseModel DeleteCarModel(int ModelId);



    }
}
