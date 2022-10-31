using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarTypeService;

namespace CarsSln.Service.CarTypeService
{
   public interface ICarTypeService
    {

        public List<CarType> GetAll();
        public CarType GetTypeByid(int TypeId);
        public List<CarType> PostCarType(ListCartype _cartype);
        public List<CarType> UpdateCartype(ListCartype _cartype);
        public ResponseModel DeleteCarType(int TypeId);

    }
}
