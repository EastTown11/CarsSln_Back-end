using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarsSln.Service.CarComponentService.CarComponentService;

namespace CarsSln.Service.CarComponentService
{
  public  interface ICarComponentService
    {
        List<CarComponent> GetCarComponentList();
        CarComponent GetCarComponentId(int ComponentId);
        ResponseModel SaveCarComponent(CarComponentList CarListModel);
        ResponseModel updateCarComponent(CarComponentList CarListModel);
        ResponseModel DeleteCarComponent(int ComponentId);






    }
}
