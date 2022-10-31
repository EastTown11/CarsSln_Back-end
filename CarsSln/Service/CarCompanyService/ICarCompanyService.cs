using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarsSln.Service.CarCompanyService.CarCompanyService;
using static CarsSln.Service.CarInfoService.CarInfoService;

namespace CarsSln.Service.CarCompanyService
{
   public interface ICarCompanyService
    {

        List<CarCompany> GetCarCompanyList();
        CarCompany GetCarCompanyId(int CarCompanyId);
        ResponseModel SaveCarCompany(CarCompanylist CarListModel);
        ResponseModel updateCarCompany(CarCompanylist CarListModel);
        ResponseModel DeleteCarCompany(int CarCompanyId);





    }
}
