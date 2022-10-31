using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarsSln.Service.CarInfoService.CarInfoService;

namespace CarsSln.Service.CarInfoService
{
   public  interface ICarInfoService
    {
        List<CarInfo> GetCarInfoList();
        CarInfo GetCarInfoById(int CarInfoId);
        List<CarInfo> SaveCarInfo(CarList CarListModel);
        List<CarInfo> updateCarInfo(CarList CarListModel);
        
            ResponseModel DeleteCarInfo(int CarInfoId);



    }
}
